using System;
 namespace Basic
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //if (name == NULL) name = "Guest";
            Console.WriteLine("Hello " + name + " how are you?");
        }
    }
}