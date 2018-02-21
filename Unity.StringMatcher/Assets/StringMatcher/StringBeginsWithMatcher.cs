namespace StringMatcher
{
    public class StringBeginsWithMatcher : AbstractStringMatcher
    {
        public StringBeginsWithMatcher(string matcher) : base(matcher)
        {
        }

        public override bool Match(string input)
        {
            return IgnoreCase ? input.ToLower().IndexOf(Matcher.ToLower()) == 0 : input.IndexOf(Matcher) == 0;
        }
    }
}