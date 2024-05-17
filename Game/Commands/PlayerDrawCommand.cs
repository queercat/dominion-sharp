using System;
using System.Windows.Input;

namespace DominionSharp;

[Serializable]
public class PlayerDrawCommand : ICommand
{
    public Guid PlayerId { get; set; }
}
