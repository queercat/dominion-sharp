using System;
using System.Collections.Generic;
using System.Text;

namespace DominionSharp;

public interface IPlayer : IGameEntity
{
    Guid Id { get; }
    string Name { get; }
    List<ICard> Library { get; set; }
    List<ICard> Hand { get; set; }
    List<ICard> Play { get; set; }
    List<ICard> Discard { get; set; }

    public void Draw(IGameState gameState);
}
