﻿using System.Collections.Generic;

namespace code.enumerables
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<Item> one_at_a_time<Item>(this IEnumerable<Item> items)
    {
      foreach (var item in items)
        yield return item;
    }
  }
}