using System.Text.RegularExpressions;

namespace StringMatcher
{
    public class StringRegexMatcher : AbstractStringMatcher
    {
        private Regex regex;
      
        public string Matcher
        {
            set
            {
                base.Matcher = value;
                UpdateRegex();
            }
        }

        public bool IgnoreCase {
            set
            {
                base.IgnoreCase = value;
                UpdateRegex();
            }
        }

        private void UpdateRegex()
        {
            regex = new Regex(base.Matcher, base.IgnoreCase ? RegexOptions.IgnoreCase : RegexOptions.None);
        }

        public StringRegexMatcher(string matcher) : base(matcher)
        {
            Matcher = matcher;
        }

        public override bool Match(string input)
        {
            return regex.IsMatch(input);
        }
    }
}