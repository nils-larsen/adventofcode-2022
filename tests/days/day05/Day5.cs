using days.day02;

namespace days.day05;

public class Day5
{
    private const string InputFile = "day05/day5.txt";
    private readonly IEnumerable<string> _testData = new List<string>
    {
        "    [D]    ",    
        "[N] [C]    ",    
        "[Z] [M] [P]",
        " 1   2   3 ",
        "",
        "move 1 from 2 to 1",
        "move 3 from 1 to 3",
        "move 2 from 2 to 1",
        "move 1 from 1 to 2"
    };
    
    [Fact]
    public void Part1_The_String_Of_Popped_And_Pushed_Stacks_Should_Be_CMZ()
    {
        var stacks = new List<Stack<char>>();
        stacks.AddRange(Enumerable.Range(0, 3).Select(_ => new Stack<char>()));

        _testData
            .TakeWhile(line => line.Contains("["))
            .AddToStack(stacks);

        _testData.Skip(5).MoveElements(stacks);

        string.Join("", stacks.Select(x => x.First()))
            .Should()
            .Be("CMZ");
    }

    [Fact]
    public void Part1_The_String_Of_Popped_And_Pushed_Stacks_Should_Be_BZLVHBWQF()
    {
        var stacks = new List<Stack<char>>();
        stacks.AddRange(Enumerable.Range(0, 9).Select(_ => new Stack<char>()));

        File.ReadLines(InputFile)
            .TakeWhile(line => line.Contains("["))
            .AddToStack(stacks);

        File.ReadLines(InputFile).Skip(10).MoveElements(stacks);
        
        string.Join("", stacks.Select(x => x.First().ToString()))
            .Should()
            .Be("BZLVHBWQF");
    }
    
    [Fact]
    public void Part2_Test_Refactor()
    {
        var stacks = new List<Stack<char>>();
        stacks.AddRange(Enumerable.Range(0, 3).Select(_ => new Stack<char>()));

        _testData
            .TakeWhile(line => line.Contains("["))
            .AddToStack(stacks);
        
        _testData.Skip(5).MoveRanges(stacks);

        string.Join("", stacks.Select(x => x.First()))
            .Should()
            .Be("MCD");
    }
    
    [Fact]
    public void Part2_Test_()
    {
        var stacks = new List<Stack<char>>();
        stacks.AddRange(Enumerable.Range(0, 9).Select(_ => new Stack<char>()));

        File.ReadLines(InputFile)
            .TakeWhile(line => line.Contains("["))
            .AddToStack(stacks);

        File.ReadLines(InputFile).Skip(10).MoveRanges(stacks);

        string.Join("", stacks.Select(x => x.First().ToString()))
            .Should()
            .Be("TDGJQTZSL");
    }
}