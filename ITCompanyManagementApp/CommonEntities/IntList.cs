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

    public bool Contains(int data)
    {
        IntNode temp = Head;
        while (temp != null)
        {
            if (temp.Data == data)
            {
                return true;
            }

            temp = temp.Next;
        }

        return false;
    }
    
    // finding by indexer. debug this to see how it works. 
    public int this[int index]
    {
        get
        {
            int count = 0;
            IntNode temp = Head;
    
            if (index == 0)
            {
                return Head.Data;
            }
            while (count++ != index)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }
    }
}