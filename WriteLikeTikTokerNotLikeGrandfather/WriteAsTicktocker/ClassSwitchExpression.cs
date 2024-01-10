using Microsoft.VisualStudio.TestTools.UnitTesting;

internal class ClassSwitchExpression
{
    private static void MainSwitchExpression(string[] args)
    {
        Assert.AreEqual(ConvertValues("undefined"), "undefined");
        Assert.AreEqual(ConvertValues("undefiNed"), "undefined");
        Assert.AreEqual(ConvertValues("one"), "number");
        Assert.AreEqual(ConvertValues("three"), "number");
        Assert.AreEqual(ConvertValues(null), String.Empty);
        Assert.AreEqual(ConvertValues("undef11ined"), "undef11ined");
    }

    static string ConvertValues(string? strVal)
    {
        // condition => result
        return strVal switch
        {
            null => string.Empty,
            var x when x.Contains("one") || x.Contains("two") || x.Contains("three") => "number",
            var x when x.ToLower().Equals("undefined") => "undefined",
            _ => strVal
        };
    }

    static string ConvertValues2(string? strVal)
    {
        return strVal == null
            ? string.Empty
            : strVal.ToLower().Equals("undefined")
                ? "undefined"
                : strVal;
    }

    static string ConvertValues1(string? strVal)
    {
        if (strVal == null)
        {
            return string.Empty;
        }
        else if (strVal.ToLower().Equals("undefined"))
        {
            return "undefined";
        }
        else
        {
            return strVal;
        }
    }
}