using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DominionSharp;

public class Player : IPlayer
{
    public Player(string name, Guid? id)
    {
        this.Name = name;
        this.Id = id ?? new Guid();

        this.Library = new();
        this.Hand = new();
        this.Play = new();
        this.Discard = new();
    }

    public Guid Id { get; }

    public string Name { get; }

    public List<ICard> Library { get; set; }
    public List<ICard> Hand { get; set; }
    public List<ICard> Play { get; set; }
    public List<ICard> Discard { get; set; }

    public void Draw(IGameState gameState)
    {
        if (this.Library.Count <= 0)
        {
            gameState.Broadcast(new PlayerShuffleCommand()
            {
                PlayerId = this.Id,
                ShuffleDiscard = true
            });
            this.Discard.Shuffle();
        }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        throw new NotImplementedException();
    }

    public void Update(GameTime gameTime)
    {
        throw new NotImplementedException();
    }
}
