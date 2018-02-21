using System;

namespace StringMatcher
{
    public class StringIsMatcher : AbstractStringMatcher
    {
        public StringIsMatcher(string matcher) : base(matcher)
        {
        }
        
        public override bool Match(string input)
        {
            return string.Equals(input, Matcher, IgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
        }
    }
}    