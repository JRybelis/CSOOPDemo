using System.Collections.Generic;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.Comparer
{
    public class EmployeeLastNameLengthComparer:IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}

