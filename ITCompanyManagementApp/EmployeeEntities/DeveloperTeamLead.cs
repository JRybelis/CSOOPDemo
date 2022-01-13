namespace ITCompanyManagementApp.EmployeeEntities
{
    public class DeveloperTeamLead: Developer, ITaskAssigner
    {
        public DeveloperTeamLead(string firstName, string lastName, int taxId, string programmingLanguage) : base(firstName, lastName, taxId, programmingLanguage)
        {
            
        }
        public void AssignTask(string Task)
        {
            //do something
        }
    }
}