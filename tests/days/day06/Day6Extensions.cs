namespace days.day06;

public static class Day6Extensions
{
    public static IEnumerable<string> SlidingWindow(this string text, int windowSize)
    {
        var index = 0;
        for (var i = 0; i < text.Length - windowSize; i++)
        {
            var substring = text.Substring(index, windowSize);
            index++;
            yield return substring;
        }
    }

    public static int Add(this int term, int otherTerm)
    {
        return term + otherTerm;
    }
}