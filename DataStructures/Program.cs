using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search Operations !");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);
            List.RemoveFirstNode();
            Console.WriteLine("After removing is : ");
            List.Display();
            List.InsertAtParticularPosition(2, 30);
        }

    }
}