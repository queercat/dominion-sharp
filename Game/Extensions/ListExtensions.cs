using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DominionSharp;

public static class ListExtensions
{
    public static void Shuffle<T>(this List<T> values)
    {
        for (var i = 0; i < values.Count - 1; ++i)
        {
            var j = RandomNumberGenerator.GetInt32(0, i + 1);
            (values[j], values[i]) = (values[i], values[j]);
        }
    }
}
