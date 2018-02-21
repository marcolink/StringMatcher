using System.Collections.Generic;

namespace StringMatcher
{
    public class StringMatcherCollection : IStringMatcher
    {
        private readonly List<IStringMatcher> matchers;
        
        public bool IgnoreCase { get; set; }

        public StringMatcherCollection()
        {
            matchers = new List<IStringMatcher>();
        }

        public void AddMatcher(IStringMatcher matcher)
        {
            matchers.Add(matcher);
        }
        
        public bool Match(string input)
        {
            foreach (var matcher in matchers)
            {
                if (!matcher.Match(input))
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}