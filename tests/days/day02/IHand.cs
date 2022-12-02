namespace days.day02;

public interface IHand
{
    bool ChooseHand(string you);
    Score Fight(string opponent);
}

public record Score(int Shape, int Outcome);

public record Round(string Opponent, string You);