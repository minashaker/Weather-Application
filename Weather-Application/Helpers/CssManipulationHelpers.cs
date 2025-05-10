namespace Weather_Application.Helpers;

public static class CssManipulationHelpers
{
    public static string ChangeBackgroundColorOnUniqueCityCode(string? uniqueCityName)
    {
        if (uniqueCityName == "LDN")
        {
            return $"bg-blue-500";
        }else if (uniqueCityName == "NYC")
        {
            return $"bg-lime-400";
        }
        else
        {
            return $"bg-yellow-400";
        }
    }
}