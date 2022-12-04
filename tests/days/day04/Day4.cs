namespace days.day04;

public class Day4
{
    private const string InputFile = "day04/day4.txt";

    private readonly IEnumerable<string> _testData = new List<string>
    {
        "2-4,6-8",
        "2-3,4-5",
        "5-7,7-9",
        "2-8,3-7",
        "6-6,4-6",
        "2-6,4-8"
    };

    [Fact]
    public void Part1_Big_List_Should_Fully_Contain_2_Pairs()
    {
        _testData
            .Select(line => line.Split(',', '-').Select(int.Parse).ToList())
            .Count(x => (x[0] <= x[2] && x[1] >= x[3]) || (x[0] >= x[2] && x[1] <= x[3]))
            .Should()
            .Be(2);
    }

    [Fact]
    public void Part1_Big_List_Should_Fully_Contain_515_Pairs()
    {
        File
            .ReadLines(InputFile)
            .Select(line => line.Split(',', '-').Select(int.Parse).ToList())
            .Count(x => (x[0] <= x[2] && x[1] >= x[3]) || (x[0] >= x[2] && x[1] <= x[3]))
            .Should()
            .Be(515);
    }

    [Fact]
    public void Part2_Big_List_Should_Have_4_Overlapping_Pairs()
    {
        _testData
            .Select(line => line.Split(',', '-').Select(int.Parse).ToList())
            .Count(x => (x[0] <= x[2] && x[1] >= x[2]) || (x[0] >= x[2] && x[0] <= x[3]))
            .Should()
            .Be(4);
    }

    [Fact]
    public void Part2_Big_List_Should_Have_883_Overlapping_Pairs()
    {
        File
            .ReadLines(InputFile)
            .Select(line => line.Split(',', '-').Select(int.Parse).ToList())
            .Count(x => (x[0] <= x[2] && x[1] >= x[2]) || (x[0] >= x[2] && x[0] <= x[3]))
            .Should()
            .Be(883);
    }
}