namespace ITCompanyManagementApp.EmployeeEntities;

public class BusinessAnalyst:Employee
{
    public string ToolUsed { get; set; }
    
    public BusinessAnalyst(string firstName, string lastName, int taxId, string toolUsed) : base(firstName, lastName, taxId)
    {
        ToolUsed = toolUsed;
    }
}