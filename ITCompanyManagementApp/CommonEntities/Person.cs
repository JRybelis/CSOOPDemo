namespace ITCompanyManagementApp.CommonEntities;

public abstract class Person
{
    private string _firstName;
    //properties to be used, in order to avoid fields, as above
    public string FirstName
    {
        get
        {
            return "Mr. " + _firstName;
        }
        set
        {
            //use static method as an extension method for string type methods, to do the things I need.
            if (value.IsStartFromCapitalLetter()) //can call the method directly, because "this" was a parameter in it.
            {
                _firstName = value;
            }
        }
    }
    public string LastName { get; private set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}