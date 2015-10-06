using System;
using code.prep.movies;
using code.enumerables;

namespace code.matching

{
  public class ComparableMatchFactory<Item, AttributeType> : ICreateMatchers<Item, AttributeType> 
    where AttributeType : IComparable<AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;
    ICreateMatchers<Item, AttributeType> original;

    public ComparableMatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor, ICreateMatchers<Item, AttributeType> original)
    {
      this.accessor = accessor;
      this.original = original;
    }

    public IMatchAn<Item> create_anonymous_match(Criteria<Item> criteria)
    {
        return original.create_anonymous_match(criteria);
    }

    public IMatchAn<Item> greater_than(AttributeType value)
    {
      return create_anonymous_match(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchAn<Item> between(AttributeType start, AttributeType end)
    {
      return create_anonymous_match(x => accessor(x).CompareTo(start) >= 0 &&
                               accessor(x).CompareTo(end) <= 0);
    }

    public IMatchAn<Item> equal_to(AttributeType value)
    {
      return original.equal_to(value);
    }

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
      return original.equal_to_any(values);
    }

    public IMatchAn<Item> not_equal_to(AttributeType value)
    {
      return original.not_equal_to(value);
    }
  }
}