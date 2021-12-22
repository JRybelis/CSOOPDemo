namespace ITCompanyManagementApp.EmployeeEntities;

public class QAEngineerTeamLead: QAEngineer, ITaskAssigner
{
    public QAEngineerTeamLead(string firstName, string lastName, int taxId, string testSpecialisation) : base(firstName, lastName, taxId, testSpecialisation)
    {
        TestSpecialisation = testSpecialisation;
    }
    public void AssignTask(string Task)
    {
        //do something
    }
}