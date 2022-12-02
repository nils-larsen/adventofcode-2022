namespace days.day02;

public record Rock : IHand
{
    public static int Score => 1;
    public static string EncryptedShape => "A";

    public bool ChooseHand(string you) => you == "X";
    
    public Score Fight(string opponent)
    {
        if (opponent == Scissors.EncryptedShape)
            return new Score(Score, Winning.Outcome);

        if (opponent == EncryptedShape)
            return new Score(Score, Draw.Outcome);

        return new Score(Score, Losing.Outcome);
    }
}

public record Paper : IHand
{
    public static int Value => 2;
    public static string EncryptedShape => "B";

    public bool ChooseHand(string you) => you == "Y";
    
    public Score Fight(string opponent)
    {
        if (opponent == Rock.EncryptedShape)
            return new Score(Value, Winning.Outcome);

        if (opponent == EncryptedShape)
            return new Score(Value, Draw.Outcome);

        return new Score(Value, Losing.Outcome);
    }
}

public record Scissors : IHand
{
    public static int Value => 3;
    public static string EncryptedShape => "C";

    public bool ChooseHand(string you) => you == "Z";
    
    public Score Fight(string opponent)
    {
        if (opponent == Paper.EncryptedShape)
            return new Score(Value, Winning.Outcome);

        if (opponent == EncryptedShape)
            return new Score(Value, Draw.Outcome);

        return new Score(Value, Losing.Outcome);
    }
}