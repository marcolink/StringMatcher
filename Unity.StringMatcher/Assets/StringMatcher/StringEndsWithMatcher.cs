namespace StringMatcher
{
    public class StringEndsWithMatcher : AbstractStringMatcher
    {
        public StringEndsWithMatcher(string matcher) : base(matcher)
        {
        }
        
        public override bool Match(string input)
        {
            return IgnoreCase ? input.ToLower().EndsWith(Matcher.ToLower()): input.EndsWith(Matcher);
        }

    }
}