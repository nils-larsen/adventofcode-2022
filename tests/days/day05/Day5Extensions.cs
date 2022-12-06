namespace days.day05;

public static class Day5Extensions
{
    public static void AddToStack(this IEnumerable<string> input, List<Stack<char>> stacks)
    {
        input
            .Reverse()
            .ToList()
            .Select(line => line.Chunk(4).ToList()).ToList().ForEach(x =>
            {
                for (var i = 0; i < x.Count; i++)
                {
                    var h = x[i].FirstOrDefault(char.IsLetter);
                    if (char.IsLetter(h))
                    {
                        stacks[i].Push(h);
                    }
                }
            });
    }

    public static void MoveElements(this IEnumerable<string> input, List<Stack<char>> stacks)
    {
        foreach (var command in input.Select(x => x.Split(new[] { "move ", " from ", " to" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()))
        {
            var numberToMove = command[0];
            var moveFrom = command[1];
            var moveTo = command[2];

            foreach (var _ in Enumerable.Range(0, numberToMove))
            {
                var a = stacks[moveFrom-1].Pop();
                stacks[moveTo-1].Push(a);
            }
        }
    }

    public static void MoveRanges(this IEnumerable<string> input, List<Stack<char>> stacks)
    {
        foreach (var command in input.Select(x => x.Split(new[] { "move ", " from ", " to" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()))
        {
            var numberToMove = command[0];
            var moveFrom = command[1];
            var moveTo = command[2];
            
            var elements = Enumerable
                .Range(0, numberToMove)
                .Select(_ => stacks[moveFrom - 1].Pop())
                .ToList();

            elements.Reverse();

            foreach (var element in elements)
            {
                stacks[moveTo - 1].Push(element);
            }
        }
    }
}