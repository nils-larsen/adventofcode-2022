namespace days.day02;

public class Day02
{
    private const string InputFile = "day02/day2.txt";

    [Fact]
    public void The_Sum_Of_All_Rounds_Should_Be_15()
    {
        var hands = new List<IHand> { new Rock(), new Paper(), new Scissors() };
        var game = new List<Round> { new("A", "Y"), new("B", "X"), new("C", "Z") };

        game
            .Select(round => hands.First(x => x.ChooseHand(round.You)).Fight(round.Opponent))
            .Sum(score => score.Shape + score.Outcome)
            .Should()
            .Be(15);
    }

    [Fact]
    public void Part1_The_Sum_Of_All_Rounds_Should_Be_12156()
    {
        var hands = new List<IHand> { new Rock(), new Paper(), new Scissors() };

        File.ReadLines(InputFile)
            .Select(line => line.Split(" "))
            .Select(x => new Round(x.First(), x.Last()))
            .Select(round => hands.First(x => x.ChooseHand(round.You)).Fight(round.Opponent))
            .Sum(score => score.Shape + score.Outcome)
            .Should()
            .Be(12156);
    }

    [Fact]
    public void The_Sum_Of_All_Correctly_Decrypted_Rounds_Should_Be_12()
    {
        var hands = new List<IHand> { new Winning(), new Losing(), new Draw() };
        var game = new List<Round> { new("A", "Y"), new("B", "X"), new("C", "Z") };

        game
            .Select(round => hands.First(x => x.ChooseHand(round.You)).Fight(round.Opponent))
            .Sum(score => score.Shape + score.Outcome)
            .Should()
            .Be(12);
    }

    [Fact]
    public void Part2_The_Sum_Of_All_Correctly_Decrypted_Rounds_Should_Be_10835()
    {
        var hands = new List<IHand> { new Winning(), new Losing(), new Draw() };

        File
            .ReadLines(InputFile)
            .Select(line => line.Split(" "))
            .Select(x => new Round(x.First(), x.Last()))
            .Select(round => hands.Single(x => x.ChooseHand(round.You)).Fight(round.Opponent))
            .Sum(score => score.Shape + score.Outcome)
            .Should()
            .Be(10835);
    }
}