using System;
using code.enumerables;
using code.prep.movies;

namespace code.matching
{
  public class ComparableMatchFactory<Item, AttributeType>
    where AttributeType : IComparable<AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;

    public ComparableMatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> greater_than(AttributeType value)
    {
      return new AnonymousMatch<Item>(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchAn<Item> between(AttributeType start, AttributeType end)
    {
      return new AnonymousMatch<Item>(x => accessor(x).CompareTo(start) >= 0 &&
      accessor(x).CompareTo(end) <=0);
    }

    // wrap around the MatchFactory
    public IMatchAn<Item> equal_to(AttributeType value)
    {
        return new MatchFactory<Item, AttributeType>(accessor).equal_to(value);
    }

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
        return new MatchFactory<Item, AttributeType>(accessor).equal_to_any(values);
    }

    public IMatchAn<Item> not_equal_to(AttributeType value)
    {
        return new MatchFactory<Item, AttributeType>(accessor).not_equal_to(value);
    }
  }
}