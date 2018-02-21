namespace StringMatcher
{
    public class StringMatcherBuilder : IStringMatcher
    {
        private readonly StringMatcherCollection _matchers;
        
        public StringMatcherBuilder()
        {
            _matchers = new StringMatcherCollection();
        }

        public StringMatcherBuilder addMatcher(IStringMatcher matcher)
        {
            _matchers.AddMatcher(matcher);
            return this;
        }

        public bool IgnoreCase { get; set; }
        
        public bool Match(string input)
        {
            return _matchers.Match(input);
        }
    }
}