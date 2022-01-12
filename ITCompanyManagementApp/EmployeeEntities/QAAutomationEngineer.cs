using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.EmployeeEntities
{
    public class QaAutomationEngineer:Employee
    {
        public string ProgrammingLanguage { get; set; }
        public string TestSpecialisation { get; set; }
    
        public QaAutomationEngineer(string firstName, string lastName, int taxId, string programmingLanguage, string testSpecialisation) : base(firstName, lastName, taxId)
        {
            ProgrammingLanguage = programmingLanguage;
            TestSpecialisation = testSpecialisation;
        }

        public override string ProduceWorkResults()
        {
            return "I have automated something.";
        }
    
        public override string ToString()
        {
            return base.ToString() + ProgrammingLanguage + ", " + TestSpecialisation;
        }
    }
}

