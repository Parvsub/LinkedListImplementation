namespace LinkedListImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<String> linkedList = new LinkedListNode<String>();

            linkedList.AddFirst("Praveen");
            linkedList.AddFirst("Mohan");
            linkedList.AddFirst("Sudheer");
            linkedList.Display();

            linkedList.AddLast("Rohith");
            linkedList.AddLast("Dhoni");
            linkedList.Display();


            linkedList.AddAfter("Mohan", "Kholi");
            linkedList.Display();

            linkedList.DeleteFirst();
            linkedList.Display();

            linkedList.DeleteLast();
            linkedList.Display();

            linkedList.DeleteParticular("Kholi");
            linkedList.Display();
        }
    }
}