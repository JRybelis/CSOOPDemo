namespace ITCompanyManagementApp.CommonEntities
{
    public class MyList<T>
    {
        public MyNode<T> Head { get; set; }
        public MyNode<T> Tail { get; set; }
        
        public MyList()
        {
            Head = null;
        }
    
        public void Add(T data)
        {
            MyNode<T> node = new MyNode<T>(data);
            
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
    
        public bool Contains(T data)
        {
            MyNode<T> temp = Head;
            
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    return true;
                }
    
                temp = temp.Next;
            }
    
            return false;
        }
        
        // finding by indexer. debug this to see how it works. 
        public T this[int index]
        {
            get
            {
                int count = 0;
                MyNode<T> temp = Head;
        
                if (index == 0)
                {
                    return temp.Data;
                }
                while (count++ != index)
                {
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }
    }
}

