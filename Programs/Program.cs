using System;
using LearnCollections;
 namespace Basic
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " how are you?");

            //list implementation
            Collections c1 = new Collections();
            c1.LearnList();

        }
    }
}