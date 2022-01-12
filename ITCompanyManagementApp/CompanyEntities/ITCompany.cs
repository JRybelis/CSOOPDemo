using System.Text;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.CompanyEntities;

public class ITCompany
{
    public static int AllHiredEmployeesInAllCompanies = 0; //static field, to count across all class instances. Dangerous, rarely necessary
    private int _hiredEmployees;
    public Employee Director { get; }
    public string Name { get; }
    internal List<Employee> Employees { get; set; }
    
    public ITCompany(string name, Employee director)
    {
        Director = director;
        Name = name;

        Employees = new List<Employee>();
        _hiredEmployees = 0;
    }

    public Employee this[int taxId] //indexer - read on it.Makes the presentation of the object as an array.
    {
        get
        {
            foreach (var employee in Employees)
            {
                if (employee.TaxID == taxId)
                {
                    return employee;
                }
            }
            return null;
        }
    }

    public Employee this[string firstName, string lastName]
    {
        get
        {
            foreach (var employee in Employees)
            {
                if (employee.FirstName == firstName && employee.LastName == lastName)
                {
                    return employee;
                }
            }
            return null;
        }
    }

    public void Hire(Employee employee)
    {
        Employees.Add(employee);
    }

    public void HireMultipleEmployees(List<Employee> employees)
    {
        Employees.AddRange(employees);
    }
    public void Fire(int taxID)
    {
        Employee toBeFired = null;
        
        foreach (var employee in Employees)
        {
            if (employee.TaxID == taxID)
            {
                toBeFired = employee;
                break;
            }    
        }

        if (toBeFired != null)
        {
            Employees.Remove(toBeFired);
        }
    }

    public string GetCompanyResults()
    {
        var builder = new StringBuilder(); // string is immutable, takes up a lot of memory. Combining a lot of them is better with a special less memory consuming builder, to make the operation quicker.
        for (int i = 0; i < _hiredEmployees; i++)
        {
            builder.Append(Employees[i].ProduceWorkResults());
            builder.Append('\n');
        }

        return builder.ToString();
    }

    public string GetCompanyInformation()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < _hiredEmployees; i++)
        {
            builder.Append(Employees[i].ToString());
            builder.Append('\n');
        }

        return builder.ToString();
    }

    public void DoTheTask(string taskToBeDone)
    {
        foreach (var employee in Employees)
        {
            if (employee is ITaskAssigner)
            {
                (employee as ITaskAssigner).AssignTask((taskToBeDone));
                break;
            }    
        }
    }
    
    public void DemonstrateResults()
    {
        foreach (var employee in Employees)
        {
            if (employee is IDemonstrator)
            {
                (employee as IDemonstrator).MakeDemo();
                break;
            }    
        }
    }

    public List<Employee> GetEmployeeByConditionID(Func<int,bool> condition) // Func<input,output> syntactic sugar - generic delegate. No need to declare delegates separately.
    {
        List<Employee> selectedEmployees = new List<Employee>();
        
        foreach (var employee in Employees)
        {
            if (condition(employee.TaxID))
            {
                selectedEmployees.Add(employee);
            }    
        }

        return selectedEmployees;
    }
    
    
}