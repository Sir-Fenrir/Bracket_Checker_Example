namespace Bracket_Checker;

public static class BracketChecker
{
    public static bool Check(string input)
    {
        var openCount = 0;
        var closedCount = 0;
        foreach (var c in input)
        {
            switch (c)
            {
                case '(':
                    openCount++;
                    break;
                case ')':
                    closedCount++;
                    break;
            }
        }
        return openCount == closedCount;
    }
}