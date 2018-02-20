# StringMatcher
A Simple string matcher builder for Unity (works also on normal c# projects).

## Usage

### Direct use of *StringMatcherBuilder*

```csharp
var matcher = new StringMatcherBuilder()
	.addMatcher(new StringBeginsWithMatcher("Hell"))
   	.addMatcher(new StringContainsMatcher("World"));

Assert.IsTrue(matcher.Match("Hello World"));
Assert.IsFalse(matcher.Match("Hello Planet"));
```

