using System;
using System.Collections.Generic;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");


            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);

            List.display();

        }
    }
}