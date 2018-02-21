namespace StringMatcher
{
    public class StringContainsMatcher : AbstractStringMatcher
    {

        public StringContainsMatcher(string matcher) : base(matcher)
        {
        }

        public override bool Match(string input)
        {
            return IgnoreCase ? input.ToLower().IndexOf(Matcher.ToLower()) != -1 : input.IndexOf(Matcher) != -1;
        }
    }
}