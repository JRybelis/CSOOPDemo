namespace ITCompanyManagementApp.EmployeeEntities
{
    public class QAEngineerTeamLead: QaEngineer, ITaskAssigner
    {
        public QAEngineerTeamLead(string firstName, string lastName, int taxId, string testSpecialisation) : base(firstName, lastName, taxId, testSpecialisation)
        {
            
        }
        public void AssignTask(string Task)
        {
            //do something
        }
    }
}

