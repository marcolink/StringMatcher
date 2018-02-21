using NUnit.Framework;

namespace StringMatcher
{
    [TestFixture]
    public class StringMatcherCollectionTest
    {
        private const string INPUT = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam";
        
        private StringMatcherCollection collectionMatcher;

        [SetUp]
        public void Setup()
        {
            collectionMatcher = new StringMatcherCollection();
        }

        [Test]
        public void ShouldBeValidWithoutMatcher()
        {
            Assert.True(collectionMatcher.Match(INPUT));
        }
        
        [Test]
        public void ShouldMatchCollectionOfMatcher()
        {
            collectionMatcher.AddMatcher(new StringBeginsWithMatcher("Lore"));
            collectionMatcher.AddMatcher(new StringContainsMatcher("amet"));
            Assert.True(collectionMatcher.Match(INPUT));
        }

        [Test]
        public void ShouldNotMatchCollectionOfMatcherWithInvalidMatcher()
        {
            collectionMatcher.AddMatcher(new StringBeginsWithMatcher("Lore"));
            collectionMatcher.AddMatcher(new StringContainsMatcher("amet"));
            collectionMatcher.AddMatcher(new StringEndsWithMatcher("Random String"));
            Assert.False(collectionMatcher.Match(INPUT));
        }
    }
}