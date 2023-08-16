using System;

namespace Foundations
{                                       // Ctrl k + Ctrl f realigns the code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Hello World type of thing");

            char c = 'a';
            var i = 1;      // Automatically configures the datatype

            Console.WriteLine("Type of c: " + c.GetType());

            //String interpolation  
            Console.WriteLine($"The value of i is: {i} and it is of type: {i.GetType()}");
            Console.WriteLine(i.GetType());

            string paragraph = $@"Displaying a paragraph: 
            {i++} First line of para 
            {i++} Second line of para";

            Console.WriteLine(paragraph);

            Console.ReadKey();
        }
    }
}