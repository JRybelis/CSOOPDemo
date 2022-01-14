using System.Collections.Generic;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.Comparer
{
     public class EmployeeTaxIDComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.TaxID.CompareTo(y.TaxID);
        }
    }
}