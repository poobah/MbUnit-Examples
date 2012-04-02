using System.Text.RegularExpressions;

public class AlphaString : IAlphaString
{
    public bool ValidString(string inputString)
    {
        //return true;
        Regex r = new Regex("[a-zA-Z]", RegexOptions.None);
        return r.IsMatch(inputString);
    }
}