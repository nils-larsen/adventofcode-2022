namespace days.day03;

public static class ListExtensions
{
    public static IEnumerable<List<string>> ToMatrix(this IEnumerable<string> list, int nDimension)
    {
        var aList = list.ToList();

        for (var i = 0; i < aList.Count / nDimension; i++)
        {
            var list2 = new List<string>();
            
            for (var j = 0; j < nDimension; j++)
            {
                list2.Add(aList[i * nDimension + j]);
            }
            yield return list2;
        }
    }
}