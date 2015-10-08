using System;

namespace code.ranges
{
  public class InclusiveRangeWithNoUpperBound<Value> : IContainValues<Value> where Value : IComparable<Value>
  {
    Value start;

    public InclusiveRangeWithNoUpperBound(Value start)
    {
      this.start = start;
    }

    public bool contains(Value value)
    {
      return value.CompareTo(start) >= 0;
    }
  }
}