using System.Diagnostics.CodeAnalysis;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.Comparer;

public class EmployeeTaxIDComparer: IComparer<Employee>
{
    public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
    {
        if (x.TaxID == y.TaxID)
        {
            return 0;
        }

        if (x.TaxID > y.TaxID)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}