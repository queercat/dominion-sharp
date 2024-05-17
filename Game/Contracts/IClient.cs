using System;
using System.Threading.Tasks;

namespace DominionSharp;

public interface IClient
{
    Guid Id { get; set; }

    Task Send(ICommand command);
}
