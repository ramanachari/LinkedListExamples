using System;

namespace LinkedList
{
    static class Program
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;
            int data;
            LinkedList linkedList = new LinkedList();
            do
            {

                Console.WriteLine("1. Insert First");
                Console.WriteLine("2. Insert Last");
                Console.WriteLine("3. Insert At spec position");
                Console.WriteLine("4. Reverse List");
                Console.WriteLine("<<< Enter Choice >>>");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter node data");
                        data= Convert.ToInt32(Console.ReadLine());
                        linkedList.InsertFront(data);
                        break;
                    case 2:
                        Console.WriteLine("Enter node data");
                        data=Convert.ToInt32(Console.ReadLine());
                        linkedList.InsertRare(data);
                        break;
                    case 3:
                        Console.WriteLine("Enter node data");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position");
                        int pos= Convert.ToInt32(Console.ReadLine());
                        linkedList.InsertAtPosition(data,pos);
                        break;
                    case 4:
                        linkedList.ReverseList();
                        break;
                }
                Console.WriteLine("Linked List Elements are: ");
                linkedList.PrintList();

                Console.WriteLine("Press Y to continue");
                ch =Console.ReadLine()[0];

            } while (ch != 'Y' || ch != 'y');
        }
    }
}
