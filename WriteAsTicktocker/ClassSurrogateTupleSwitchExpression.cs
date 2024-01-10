using Microsoft.VisualStudio.TestTools.UnitTesting;

internal class ClassSurrogateTupleSwitchExpression
{
    private static void MainSurrogateTupleSwitchExpression(string[] args)
    {
        Assert.AreEqual(ConvertMultiValues("undefined", true), "undefined");
        Assert.AreEqual(ConvertMultiValues("Undefined", true), "undefined");
        Assert.AreEqual(ConvertMultiValues(null, true), String.Empty);

        Assert.AreEqual(ConvertMultiValues(null, false), null);
        Assert.AreEqual(ConvertMultiValues("Undfsefifsafaned", false), "Undfsefifsafaned");
    }

    //if return is not includes "?", warning will be created because we can return null but we don't tell it explicitly
    static string? ConvertMultiValues(string? strValue, bool normalize)
    {
        return (strValue, normalize) switch
        {
            (null, true) => string.Empty,
            ("Undefined", true) => "undefined",
            _ => strValue,
        };
    }

    static string ConvertMultiValues1(string strValue, bool normalize)
    {
        if (normalize)
        {
            if (strValue == null)
            {
                return string.Empty;
            }
            else if (strValue == "Undefined")
            {
                return "undefined";
            }
            else
            {
                return strValue;
            }
        }
        else
        {
            return strValue;
        }
    }
}