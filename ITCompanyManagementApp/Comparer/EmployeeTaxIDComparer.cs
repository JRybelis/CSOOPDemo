using System.Diagnostics.CodeAnalysis;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.Comparer;

public class EmployeeTaxIDComparer: IComparer<Employee>
{
    public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
    {
        return x.TaxID.CompareTo(y.TaxID);
    }
}