using System;

namespace DominionSharp;

[Serializable]
public class PlayerJoinCommand : ICommand
{
    public string Name { get; set; }
    public Guid PlayerId { get; set; }
}
