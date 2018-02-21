using NUnit.Framework;

namespace StringMatcher
{
    [TestFixture]
    public class StringMatcherTest
    {
        private const string INPUT = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam";

        #region StringContainesMatcher

        [Test]
        public void ShouldContainString()
        {
            var matcher = new StringContainsMatcher("Lorem");
            Assert.True(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldNotMatchContainStringWithWrongCase()
        {
            var matcher = new StringContainsMatcher("Dolor");
            Assert.False(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldMatchWrongCaseString()
        {
            var matcher = new StringContainsMatcher("Dolor") {IgnoreCase = true};
            Assert.True(matcher.Match(INPUT));
        }

        #endregion

        #region StringBeginsWithMatcher

        [Test]
        public void ShouldBeginWithString()
        {
            var matcher = new StringBeginsWithMatcher("Lorem");
            Assert.True(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldNotbeginWith()
        {
            var matcher = new StringBeginsWithMatcher("Dolor");
            Assert.False(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldMatchBeginsWithWrongCaseString()
        {
            var matcher = new StringBeginsWithMatcher("lorem") {IgnoreCase = true};
            Assert.True(matcher.Match(INPUT));
        }

        #endregion

        #region StringEndsWithMatcher

        [Test]
        public void ShouldEndWithString()
        {
            var matcher = new StringEndsWithMatcher("iam");
            Assert.True(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldEndbeginWith()
        {
            var matcher = new StringEndsWithMatcher("diamx");
            Assert.False(matcher.Match(INPUT));
        }

        [Test]
        public void ShouldMatchEndsWithWrongCaseString()
        {
            var matcher = new StringEndsWithMatcher("Diam") {IgnoreCase = true};
            Assert.True(matcher.Match(INPUT));
        }

        #endregion

        #region StringIsMatcher

        [Test]
        public void ShouldMatchSameString()
        {
            var matcher = new StringIsMatcher("hello world");
            Assert.True(matcher.Match("hello world"));
        }

        [Test]
        public void ShouldNotMatchDifferentString()
        {
            var matcher = new StringIsMatcher("hello world");
            Assert.False(matcher.Match("helloworld"));
        }

        [Test]
        public void ShouldMatchSameStringWithDifferentCase()
        {
            var matcher = new StringIsMatcher("hello world") {IgnoreCase = true};
            Assert.True(matcher.Match("Hello World"));
        }

        #endregion

        #region StringRegexMatcher

        [Test]
        public void ShouldMatchWithGivenPasswordRegex()
        {
            var matcher = new StringRegexMatcher(@"^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$");
            Assert.True(matcher.Match("HelloWorld102"));
        }

        [Test]
        public void ShouldMatchWithUpdatedRegex()
        {
            var matcher = new StringRegexMatcher(@"^[0-9]+$");
            matcher.Matcher = @"^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$";
            Assert.True(matcher.Match("HelloWorld102"));
        }

        #endregion
    }
}