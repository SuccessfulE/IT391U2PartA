using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IT391U2
{
    class PartAU2Assignment
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 2, Part A, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 1 **********");
            Console.WriteLine();

            //Taking user input for sentance
            Console.WriteLine("Enter any word and hit enter to see the word reversed: ");
            string str = Console.ReadLine();

            //Executing user input word in reverse.
            Console.WriteLine("\nYour word in reverse is: " + revString(str));

            //*********************************************************
            //****Assignment 2, Part A, Section 2
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("**********Section 2 **********");
            Console.WriteLine();

            //Executing Queue
            Shoppers();
        }

        //Grocery Store Method
        private static void Shoppers()
        {

            Queue customers = new Queue(); //Create the queue object

            //Load the queue with names
            customers.Enqueue("Jane");
            customers.Enqueue("Bob");
            customers.Enqueue("Liza");
            customers.Enqueue("Tom");
            customers.Enqueue("Mary");

            //Displaying number of shoppers and first shopper in line
            Console.WriteLine("The number of shoppers at the grocery store is, " + customers.Count);
            Console.WriteLine("The first shopper in line is, " + customers.Peek());

            //Adding two shoppers
            customers.Enqueue("Stephen");
            customers.Enqueue("Ellen");

            //Removing three shoppers
            customers.Dequeue();
            customers.Dequeue();
            customers.Dequeue();
            
            //Displaying number of shoppers and first shopper in line
            Console.WriteLine("The number of shoppers now in line is, " + customers.Count);
            Console.WriteLine("The shopper currently first in line is, " + customers.Peek());

            Console.ReadKey();
        }

        //Stack method for reversing words
        private static string revString(string str)
        {
            Stack<string> wordStack = new Stack<String>();


            for (int i = 0; i < str.Length; i++)
                wordStack.Push(str.Substring(i, 1));
            string reversed = string.Empty;
            for (int i = 0; i < str.Length; i++)
                reversed += wordStack.Pop();
            return reversed;
        }
    }
}
