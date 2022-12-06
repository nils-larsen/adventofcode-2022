namespace days.day06;

public class Day6
{
    private const string InputFile = "day06/day6.txt";

    [Theory]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void The_First_MessageMarker_Is_Detected_After_Expected_Amount_Of_Characters(string input, int expected)
    {
        input
            .SlidingWindow(4)
            .Select(x => x.Distinct().Count() == 4)
            .TakeWhile(x => !x)
            .Count()
            .Add(4)
            .Should()
            .Be(expected);
    }
    
    [Fact]
    public void The_First_MessageMarker_Is_Detected_After_1598_Characters()
    {
       File.ReadAllText(InputFile)
            .SlidingWindow(4)
            .Select(x => x.Distinct().Count() == 4)
            .TakeWhile(x => !x)
            .Count()
            .Add(4)
            .Should()
            .Be(1598);
    }
    
    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
    public void Part2_The_First_MessageMarker_Is_Detected_After_Expected_Amount_Of_Characters(string input, int expected)
    {
        input
            .SlidingWindow(14)
            .Select(x => x.Distinct().Count() == 14)
            .TakeWhile(x => !x)
            .Count()
            .Add(14)
            .Should()
            .Be(expected);
    }
    
    [Fact]
    public void Part2_The_First_MessageMarker_Is_Detected_After_2414_Characters()
    {
        File.ReadAllText(InputFile)
            .SlidingWindow(14)
            .Select(x => x.Distinct().Count() == 14)
            .TakeWhile(x => !x)
            .Count()
            .Add(14)
            .Should()
            .Be(2414);
    }
}