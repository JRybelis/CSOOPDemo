using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.EmployeeEntities
{
    public class QaEngineer:Employee
    {
        public string TestSpecialisation { get; set; }
    
        public QaEngineer(string firstName, string lastName, int taxId, string testSpecialisation) : base(firstName, lastName, taxId)
        {
            TestSpecialisation = testSpecialisation;
        }

        public override string ProduceWorkResults()
        {
            return "I have created a test case.";
        }
    
        public override string ToString()
        {
            return base.ToString() + TestSpecialisation;
        }
    }
}