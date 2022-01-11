namespace ITCompanyManagementApp.CommonEntities;

public abstract class Person
{
    //properties ought to be used, in order to avoid granting direct outside access to fields.
    private string _firstName; //the field comes into play, when props need to be extended with logic
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
    
    public override string ToString()
    {
        return FirstName + " " + LastName + ", ";
    }
}