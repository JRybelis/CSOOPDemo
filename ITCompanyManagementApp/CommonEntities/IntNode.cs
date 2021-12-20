namespace ITCompanyManagementApp.CommonEntities;

public class IntNode
{
    public IntNode Next { get; set; } //Next keeps sequence of elements like el1.Next = el2 el2.Next = el3 el3.Next = null 
    public int Data { get; set; }
    
    public IntNode(int data)
    {
        Data = data;
    }

    
    
    
}