using System;
using System.Collections.Generic;
using System.Linq;

namespace DominionSharp;

public static class IClientExtensions
{
    public static List<IClient> Except(this List<IClient> clients, Guid id)
    {
        return clients.Where(c => c.Id != id).ToList();
    }
}
