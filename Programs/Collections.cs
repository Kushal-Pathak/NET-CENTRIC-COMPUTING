using System.Collections.Generic;
namespace LearnCollections
{
    class Collections
    {
        public void LearnList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);
            // numbers.Insert(0, 55); //insert 55 at index 0
            // numbers.Remove(10); //removes first occurrence of 10
            // numbers.RemoveAt(1); //removes element at index 1
            // numbers.RemoveRange(1, 3); //removes element of index 1, 2, 3
            // numbers.Clear(); //clears a list
            // Console.WriteLine(numbers.Contains(11)); //checks if list contains element 1
            // Console.WriteLine(numbers.IndexOf(11)); //returns the index of element 11

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}