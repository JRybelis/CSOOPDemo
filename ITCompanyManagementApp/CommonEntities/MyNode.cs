namespace ITCompanyManagementApp.CommonEntities
{
    public class MyNode<T>
    {
        public MyNode<T> Next { get; set; } //Next keeps sequence of elements like el1.Next = el2 el2.Next = el3 el3.Next = null 
        public T Data { get; set; }
    
        public MyNode(T data)
        {
            Data = data;
        }
    }
}

