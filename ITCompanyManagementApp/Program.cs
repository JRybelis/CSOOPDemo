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

        var companyCoherent = new ITCompany("Coherent", new Developer("Mike", "Brown", 3, "C"));

        companyCoherent.Hire(person1);
        companyCoherent.Hire(person2);
        companyCoherent.Hire(person3);
        companyCoherent.Hire(person4);

        // indexers: syntactic sugar as opposed to calling company.GetEmployeeByName("John", "Cusack");
        var dummy = companyCoherent["Mr. John", "Cusack"];
        var dummy1 = companyCoherent[3];
        var dummy2 = companyCoherent[5];

        //accessing static fields is the same as calling static methods:
        Console.WriteLine(ITCompany.AllHiredEmployeesInAllCompanies);

        string companyCoherentResults = companyCoherent.GetCompanyResults();
        string companyCoherentInformation = companyCoherent.GetCompanyInformation();
        Console.WriteLine(companyCoherentResults);
        Console.WriteLine(companyCoherentInformation);

        IntList list = new IntList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        
        Console.ReadLine();
    }
}