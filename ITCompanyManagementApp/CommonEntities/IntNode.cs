namespace ITCompanyManagementApp.CommonEntities;

public class IntNode
{
    public IntNode Next { get; set; }
    public int Data { get; set; }
    
    public IntNode(int data)
    {
        Data = data;
    }

    
    
    
}