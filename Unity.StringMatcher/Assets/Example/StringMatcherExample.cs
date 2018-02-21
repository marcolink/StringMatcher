using StringMatcher;
using UnityEngine;
using UnityEngine.Assertions;

namespace Example
{
    public class StringMatcherExample : MonoBehaviour
    {
        public void Awake()
        {
            var matcher = new StringMatcherBuilder()
                .addMatcher(new StringBeginsWithMatcher("Hell"))
                .addMatcher(new StringContainsMatcher("World"));

            Assert.IsTrue(matcher.Match("Hello World"));
            Assert.IsFalse(matcher.Match("Hello Planet"));
        }
    }
}