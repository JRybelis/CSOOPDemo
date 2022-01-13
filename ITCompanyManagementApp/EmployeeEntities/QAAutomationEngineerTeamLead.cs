namespace ITCompanyManagementApp.EmployeeEntities
{
    public class QaAutomationEngineerTeamLead: QaAutomationEngineer, ITaskAssigner
    {
        public QaAutomationEngineerTeamLead(string firstName, string lastName, int taxId, string programmingLanguage, string testSpecialisation) : base(firstName, lastName, taxId, programmingLanguage, testSpecialisation)
        {
            
        }

        public void AssignTask(string Task)
        {
            //do something
        }
    }
}