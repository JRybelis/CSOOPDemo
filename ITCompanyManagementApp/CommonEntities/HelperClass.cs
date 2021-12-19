namespace ITCompanyManagementApp.CommonEntities;

public static class HelperClass // all methods in this class are static. Helper class, giving global functionality.
{
    public static bool IsStartFromCapitalLetter(this string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            return false;
        }

        return (data[0] > 'A' && data[0] < 'Z');
    }
}