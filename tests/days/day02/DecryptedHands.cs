namespace days.day02;

public record Winning : IHand
{
    public static int Outcome => 6;

    public bool ChooseHand(string you) => you == "Z";
    
    public Score Fight(string opponent)
    {
        if (opponent == Scissors.EncryptedShape)
            return new Score(Rock.Score, Outcome);

        if (opponent == Rock.EncryptedShape)

            return new Score(Paper.Value, Outcome);
        return new Score(Scissors.Value, Outcome);
    }
}

public record Draw : IHand
{
    public static int Outcome => 3;

    public bool ChooseHand(string you) => you == "Y";

    public Score Fight(string opponent)
    {
        if (opponent == Scissors.EncryptedShape)
            return new Score(Scissors.Value, Outcome);

        if (opponent == Rock.EncryptedShape)
            return new Score(Rock.Score, Outcome);

        return new Score(Paper.Value, Outcome);
    }
}

public record Losing : IHand
{
    public static int Outcome => 0;

    public bool ChooseHand(string you) => you == "X";

    public Score Fight(string opponent)
    {
        if (opponent == Scissors.EncryptedShape)
            return new Score(Paper.Value, Outcome);

        if (opponent == Rock.EncryptedShape)
            return new Score(Scissors.Value, Outcome);

        return new Score(Rock.Score, Outcome);
    }
}