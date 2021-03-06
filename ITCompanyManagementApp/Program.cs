using System;
using ITCompanyManagementApp.CommonEntities;
using ITCompanyManagementApp.CompanyEntities;
using ITCompanyManagementApp.EmployeeEntities;
using System.Collections.Generic;
using System.Text;
using ITCompanyManagementApp.Comparer;

namespace ITCompanyManagementApp
{
    class Program
{
    static void Main(string[] args)
    {
        /* type of reference is abstract class Employee, common to all of Employee class derivatives */ Employee person1 = new Developer /* object type is Developer */("John", "Cusack",
            3, "C++"); //assign another Developer object instance to 'person1 as Developer', if needed, or to 'person1' if assigning it as Employee type 
        Employee person2 = new QaAutomationEngineer("Steve", "Bannon", 4, "C#", "Web");
        Employee person3 = new BusinessAnalyst("Mike", "Judge", 5, "UML Creator");
        Employee person4 = new QaEngineer("Darren", "Willis", 6, "Mobile");
        Employee person5 = new QAEngineerTeamLead("Stephen", "Wallace", 7, "Mobile");
        Employee person6 = new DeveloperTeamLead("Carl", "Horst", 8, "Web");

        var companyCoherent = new ITCompany("Coherent", new Developer("Mike", "Brown", 3, "C"));

        companyCoherent.Hire(person1);
        companyCoherent.Hire(person2);
        companyCoherent.Hire(person3);
        companyCoherent.Hire(person4);
        companyCoherent.HireMultipleEmployees(new List<Employee>{person5, person6});

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

         
        string taskTobeAssigned = "A very important task";
        
        //interfaces allow custom sorting:
        companyCoherent.Employees.Sort(new EmployeeTaxIDComparer());
        companyCoherent.Employees.Sort(new EmployeeLastNameLengthComparer());
        
        //delegates where functions called are defined separately, below: 
        var result1 = companyCoherent.GetEmployeeByConditionID(ConditionMoreThan2);
        var result2 = companyCoherent.GetEmployeeByConditionID(ConditionMoreThan1LessOrEqual3);
        
        var result3 = companyCoherent.GetEmployeeByConditionID(delegate(int x)
        {
            return x > 4;
        });// same delegate functionality but with an anonymous function, defined at the same time the call is being made. Compiler will expand and create a method, without creating a name for it. There is no need to reuse it in the future, so no need for a name.
        
        var result4 = companyCoherent.GetEmployeeByConditionID(x => x < 7); // same but with a lambda expression (arrow function);
        
        Console.ReadLine();
    }

    static bool ConditionMoreThan2(int data)
    {
        return data > 2;
    }

    static bool ConditionMoreThan1LessOrEqual3(int data)
    {
        return data > 1 && data <= 3;
    }
}
}

