using ITCompanyManagementApp.EmployeeEntities;

namespace ITCompanyManagementApp.EmployeeEntities
{
    public class BusinessAnalystTeamLead: BusinessAnalyst, ITaskAssigner, IDemonstrator
    {
        public BusinessAnalystTeamLead(string firstName, string lastName, int taxId, string toolUsed) : base(firstName, lastName, taxId, toolUsed)
        {
            
        }
        public void AssignTask(string Task)
        {
            //Do something
        }

        public void MakeDemo()
        {
            //demonstrate the project
        }
    }
}
