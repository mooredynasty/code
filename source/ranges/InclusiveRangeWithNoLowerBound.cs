using System;

namespace code.ranges
{
  public class InclusiveRangeWithNoLowerBound<Value> : IContainValues<Value> where Value : IComparable<Value>
  {
    Value end;

    public InclusiveRangeWithNoLowerBound(Value end)
    {
      this.end = end;
    }

    public bool contains(Value value)
    {
      return value.CompareTo(end) <= 0;
    }
  }
}