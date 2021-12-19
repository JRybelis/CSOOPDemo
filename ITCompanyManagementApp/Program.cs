using System;
using ITCompanyManageApplication.Common_entity;
using ITCompanyManageApplication.CompanyEntities;
using ITCompanyManageApplication.EmployeeEntities;

namespace ITCompanyManagementApp;

class Program
{
    static void Main(string[] args)
    {
        Employee person1 = new Developer("John", "Cusack",
            3, "C++");
        Employee person2 = new Employee("Steve", "Bannon", 4);
        Employee person3 = new Employee("Mike", "Judge", 5);

        ITCompany companyCoherent = new ITCompany("Coherent", new Employee("Mike", "Brown", 3));
        ITCompany companyMicrosoft = new ITCompany("Microsoft", new Employee("Steve", "Bannon", 4));
            
        companyCoherent.Hire(person1);
        companyCoherent.Hire(person2);
        companyCoherent.Hire(person3);
        companyMicrosoft.Hire(person2);

        // indexers: syntactic sugar as opposed to calling company.GetEmployeeByName("John", "Cusack");
        var employee3 = companyCoherent["John", "Cusack"];
        var employee1 = companyCoherent[1];
        var employee2 = companyCoherent[5];

        //accessing static fields is the same as calling static methods:
        Console.WriteLine(ITCompany.AllHiredEmployeesInAllCompanies);
            
    }
}