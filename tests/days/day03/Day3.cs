namespace days.day03;

public class Day3
{
    private const string InputFile = "day03/day3.txt";
    private readonly IEnumerable<string> _testData = new List<string>()
    {
        "vJrwpWtwJgWrhcsFMMfFFhFp",
        "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
        "PmmdzqPrVvPwwTWBwg",
        "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
        "ttgJtRGJQctTZtZT",
        "CrZsJsPPZsGzwwsLwLmpwMDw"
    };
    
    [Fact]
    public void The_Sum_Of_The_Priorities_Should_Be_157()
    {
        _testData
            .Select(x => x.Chunk(x.Length / 2).ToList())
            .SelectMany(x => x[0].Intersect(x[1]))
            .Select(x => char.IsLower(x) ? x % 32 : x % 32 + 26)
            .Sum()
            .Should()
            .Be(157);
    }
    
    [Fact]
    public void Part1_The_Sum_Of_The_Priorities_Should_Be_8153()
    {
        File
            .ReadLines(InputFile)
            .Select(x => x.Chunk(x.Length / 2).ToList())
            .SelectMany(x => x[0].Intersect(x[1]))
            .Select(x => char.IsLower(x) ? x % 32 : x % 32 + 26)
            .Sum()
            .Should()
            .Be(8153);
    }
    
    [Fact]
    public void The_Sum_Of_3_Elves_Priorities_Should_Be_70()
    {
        _testData
            .ToMatrix(3)
            .SelectMany(x => x[0].Intersect(x[1]).Intersect(x[2]))
            .Select(x => char.IsLower(x) ? x % 32 : x % 32 + 26)
            .Sum()
            .Should()
            .Be(70);
    }
    
    [Fact]
    public void Part2_The_Sum_Of_3_Elves_Priorities_Should_Be_2342()
    {
        File
            .ReadLines(InputFile)
            .ToMatrix(3)
            .SelectMany(x => x[0].Intersect(x[1]).Intersect(x[2]))
            .Select(x => char.IsLower(x) ? x % 32 : x % 32 + 26)
            .Sum()
            .Should()
            .Be(2342);
    }
}