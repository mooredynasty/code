using System.Collections.Generic;
using code.prep.movies;
using code.enumerables;

namespace code.matching
{
  public class MatchFactory<Item, AttributeType> : ICreateMatchers<Item, AttributeType>
  {
    IGetAnAttributeValue<Item, AttributeType> accessor;

    public MatchFactory(IGetAnAttributeValue<Item, AttributeType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> create_anonymous_match(Criteria<Item> criteria)
    {
        return new AnonymousMatch<Item>(criteria);
    }

    public IMatchAn<Item> equal_to(AttributeType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<Item> equal_to_any(params AttributeType[] values)
    {
      return create_anonymous_match(x =>
        new List<AttributeType>(values).Contains(accessor(x)));
    }

    public IMatchAn<Item> not_equal_to(AttributeType value)
    {
      return equal_to(value).negate();
    }

  }
}