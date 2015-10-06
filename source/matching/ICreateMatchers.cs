namespace code.matching
{
  public interface ICreateMatchers<in Item, in AttributeType>
  {
    IMatchAn<Item> create_anonymous_match(Criteria<Item> criteria);
    IMatchAn<Item> equal_to(AttributeType value);
    IMatchAn<Item> equal_to_any(params AttributeType[] values);
    IMatchAn<Item> not_equal_to(AttributeType value);
  }
}