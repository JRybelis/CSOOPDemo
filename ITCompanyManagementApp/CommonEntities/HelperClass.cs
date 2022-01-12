namespace ITCompanyManagementApp.CommonEntities
{
    public static class HelperClass // all methods in this class are static. Helper class, giving global functionality.
    {
        public static bool IsStartFromCapitalLetter(this string data) //this keyword points to string type and thus this method extends the string class methods that are sealed in a DLL.
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }

            return (data[0] > 'A' && data[0] < 'Z');
        }
    }
}