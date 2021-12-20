namespace ITCompanyManagementApp.EmployeeEntities;

public class BusinessAnalyst:Employee
{
    public string ToolUsed { get; set; }
    
    public BusinessAnalyst(string firstName, string lastName, int taxId, string toolUsed) : base(firstName, lastName, taxId)
    {
        ToolUsed = toolUsed;
    }

    public override string ProduceWorkResults()
    {
        return "I have created an UML diagram";
    }
    
    public override string ToString()
    {
        return base.ToString() + ToolUsed;
    }
}