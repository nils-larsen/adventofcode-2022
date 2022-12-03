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
    public void Part1_The_Sum_Of_The_Priorities_Should_Be_157()
    {
        _testData
            .Select(rucksack => rucksack.Chunk(rucksack.Length / 2).ToList())
            .SelectMany(compartment => compartment[0].Intersect(compartment[1]))
            .Select(item => char.IsLower(item) ? item % 32 : item % 32 + 26)
            .Sum()
            .Should()
            .Be(157);
    }
    
    [Fact]
    public void Part1_The_Sum_Of_The_Priorities_Should_Be_8153()
    {
        File
            .ReadLines(InputFile)
            .Select(rucksack => rucksack.Chunk(rucksack.Length / 2).ToList())
            .SelectMany(compartment => compartment[0].Intersect(compartment[1]))
            .Select(item => char.IsLower(item) ? item % 32 : item % 32 + 26)
            .Sum()
            .Should()
            .Be(8153);
    }
    
    [Fact]
    public void Part2_The_Sum_Of_3_Elves_Priorities_Should_Be_70()
    {
        _testData
            .Chunk(3)
            .SelectMany(rucksack => rucksack[0].Intersect(rucksack[1]).Intersect(rucksack[2]))
            .Select(item => char.IsLower(item) ? item % 32 : item % 32 + 26)
            .Sum()
            .Should()
            .Be(70);
    }
    
    [Fact]
    public void Part2_The_Sum_Of_3_Elves_Priorities_Should_Be_2342()
    {
        File
            .ReadLines(InputFile)
            .Chunk(3)
            .SelectMany(rucksack => rucksack[0].Intersect(rucksack[1]).Intersect(rucksack[2]))
            .Select(item => char.IsLower(item) ? item % 32 : item % 32 + 26)
            .Sum()
            .Should()
            .Be(2342);
    }
}