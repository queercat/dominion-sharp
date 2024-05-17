using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DominionSharp;

public interface IGameState
{
    List<IPlayer> Players { get; set; }
    List<IClient> Clients { get; set; }
    void Update(ICommand command);
    Task Broadcast(ICommand command);
}
