namespace StringMatcher
{
    public interface IStringMatcher
    {
        bool IgnoreCase { get; set; }
        bool Match(string input);
    }
}