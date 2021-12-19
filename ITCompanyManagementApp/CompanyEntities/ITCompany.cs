using System;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.CompanyEntities;

public class ITCompany
{
    public static int AllHiredEmployeesInAllCompanies = 0; //static field, to count across all class instances.
    private const int MAX_EMPLOYEE_NUMBER = 10;
    private int _hiredEmployees;
    public Employee Director { get; }
    public string Name { get; }
    private Employee[] Employees { get; set; }
    
    public ITCompany(string name, Employee director)
    {
        Director = director;
        Name = name;
        
        Employees = new Employee[MAX_EMPLOYEE_NUMBER];
        _hiredEmployees = 0;
    }

    public Employee
        this[int taxId] //indexer - read on it.Makes the presentation of the object as an array.
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
        if (_hiredEmployees < MAX_EMPLOYEE_NUMBER)
        {
            Employees[_hiredEmployees] = employee;
            _hiredEmployees++;
            AllHiredEmployeesInAllCompanies++;
        }
        else
        {
            throw new Exception("Cannot hire any more people.");
        }
    }
}