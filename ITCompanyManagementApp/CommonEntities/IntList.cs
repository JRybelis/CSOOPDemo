namespace ITCompanyManagementApp.CommonEntities;

public class IntList
{
    public IntNode Head { get; set; }
    public IntNode Tail { get; set; }
    
    public IntList()
    {
        Head = null;
    }

    public void Add(int data)
    {
        IntNode node = new IntNode(data);
        
        if (Head == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
        
    }

    
    
}