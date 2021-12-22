using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.Comparer;

public class EmployeeLastNameLengthComparer:IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x.LastName.Length == y.LastName.Length)
        {
            return 0;
        }

        if (x.LastName.Length > y.LastName.Length)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}