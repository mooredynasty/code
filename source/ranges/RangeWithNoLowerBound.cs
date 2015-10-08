using System;

namespace code.ranges
{
  public class RangeWithNoLowerBound<Value> : IContainValues<Value> where Value : IComparable<Value>
  {
    Value end;

    public RangeWithNoLowerBound(Value end)
    {
      this.end = end;
    }

    public bool contains(Value value)
    {
      return value.CompareTo(end) < 0;
    }
  }
}