using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List operations");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);
            List.Display();
        }
    }
}