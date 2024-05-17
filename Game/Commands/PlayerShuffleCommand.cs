using System;

namespace DominionSharp;

public class PlayerShuffleCommand : ICommand
{
    public Guid PlayerId { get; set; }

    public bool ShuffleLibrary { get; set; }
    public bool ShuffleDiscard { get; set; }
}
