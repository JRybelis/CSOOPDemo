using System;
using ITCompanyManagementApp.CommonEntities;
using ITCompanyManagementApp.CompanyEntities;
using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp;

class Program
{
    static void Main(string[] args)
    {
        Employee person1 = new Developer("John", "Cusack",
            3, "C++");
        Employee person2 = new QAAutomationEngineer("Steve", "Bannon", 4, "C#", "Web");
        Employee person3 = new BusinessAnalyst("Mike", "Judge", 5, "UML Creator");
        Employee person4 = new QAEngineer("Darren", "Willis", 6, "Mobile");

        ITCompany companyCoherent = new ITCompany("Coherent", new Developer("Mike", "Brown", 3, "C"));
        ITCompany companyMicrosoft = new ITCompany("Microsoft", new Developer("Steve", "Bannon", 2, "Cobol"));
            
        companyCoherent.Hire(person1);
        companyCoherent.Hire(person2);
        companyCoherent.Hire(person3);
        companyMicrosoft.Hire(person4);

        // indexers: syntactic sugar as opposed to calling company.GetEmployeeByName("John", "Cusack");
        var employee3 = companyCoherent["John", "Cusack"];
        var employee1 = companyCoherent[1];
        var employee2 = companyCoherent[5];

        //accessing static fields is the same as calling static methods:
        Console.WriteLine(ITCompany.AllHiredEmployeesInAllCompanies);
            
    }
}