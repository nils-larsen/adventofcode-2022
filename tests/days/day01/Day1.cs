namespace days.day01;

public class Day1
{
    private const string InputFile = "day01/day1.txt";

    [Fact]
    public void The_Elf_Carrying_The_Most_Calories_Carries_24000()
    {
        const string testData = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";

        testData
            .Split($"{Environment.NewLine}{Environment.NewLine}")
            .Select(x => x.Split(Environment.NewLine).Select(int.Parse))
            .Select(x => x.Sum())
            .Max()
            .Should()
            .Be(24000);
    }
    
    [Fact]
    public void Part1_The_Elf_Carrying_The_Most_Calories_Carries_66719()
    {
        File
            .ReadAllText(InputFile)
            .Split($"{Environment.NewLine}{Environment.NewLine}")
            .Select(x => x.Split(Environment.NewLine).Select(int.Parse))
            .Select(x => x.Sum())
            .Max()
            .Should()
            .Be(66719);
    }
    
    [Fact]
    public void The_Top_3_Most_Carrying_Elves_Carries_Should_Carry_45000()
    {
        const string testData = "1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000";

        testData
            .Split($"{Environment.NewLine}{Environment.NewLine}")
            .Select(x => x.Split(Environment.NewLine).Select(int.Parse))
            .Select(x => x.Sum())
            .OrderDescending()
            .Take(3)
            .Sum()
            .Should()
            .Be(45000);
    }
    
    [Fact]
    public void Part2_The_Top_3_Most_Carrying_Elves_Should_Carry_198551()
    {
        File
            .ReadAllText(InputFile)
            .Split($"{Environment.NewLine}{Environment.NewLine}")
            .Select(x => x.Split(Environment.NewLine).Select(int.Parse))
            .Select(x => x.Sum())
            .OrderDescending()
            .Take(3)
            .Sum()
            .Should()
            .Be(198551);
    }
}