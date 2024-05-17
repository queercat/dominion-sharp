using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DominionSharp;

[Serializable]
public class GameState : IGameState
{
    private Guid ClientId { get; }
    public List<IPlayer> Players { get; set; }
    public List<IClient> Clients { get; set; }

    public GameState()
    {
        this.ClientId = new();
        this.Clients = new();
        this.Players = new();
    }

    public void Update(ICommand command)
    {
        if (command is PlayerDrawCommand playerDrawCommand)
        {
            this.Players.Where(p => p.Id == playerDrawCommand.PlayerId).First().Draw(this);
        }

        else if (command is PlayerJoinCommand playerJoinCommand)
        {
            var player = new Player(playerJoinCommand.Name, playerJoinCommand.PlayerId);
            this.Players.Add(player);
        }

        else
        {
            throw new NotImplementedException("Unimplemented command!");
        }
    }

    public async Task Broadcast(ICommand command)
    {
        var tasks = new List<Task>();
        foreach (var client in this.Clients.Except(this.ClientId))
        {
            tasks.Add(client.Send(command));
        }

        await Task.WhenAll(tasks);
    }
}
