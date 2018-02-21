namespace StringMatcher
{
    public abstract class AbstractStringMatcher : IStringMatcher
    {
        private string _matcher;

        public string Matcher
        {
            get { return _matcher ?? (_matcher = ""); }
            set { _matcher = value; }
        }

        public bool IgnoreCase { get; set; }

        protected AbstractStringMatcher(string matcher)
        {
            Matcher = matcher;
        }
        
        public virtual bool Match(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}