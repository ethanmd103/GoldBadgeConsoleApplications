using System;
using System.Collections.Generic;

namespace _00_Junkyard
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> line = new Queue<Customer>();

            //We need to create customers....
            Customer customerA = new Customer(1, "Terry", "Brown");
            Customer customerB = new Customer(2, "Ethan", "Davis");
            Customer customerC = new Customer(3, "Tim", "Timmy");
            Customer customerD = new Customer(4, "Jim", "Carrey");

            //Queue is F.I.F.O -> First In First Out 
            //Queue doesn't have an add method....
            //Queue has an enqueue.....
            line.Enqueue(customerA);
            line.Enqueue(customerB);
            line.Enqueue(customerC);
            line.Enqueue(customerD);

            //See whos next in line
            var customer = line.Peek();
            Console.WriteLine($"{customer.FirstName}");

            //Remove the first customer
            line.Dequeue();
            Console.WriteLine("We just removed the first customer.");

            var nextCustomer = line.Peek();
            Console.WriteLine(nextCustomer.FirstName);

            Console.WriteLine("------------------------");
            foreach (var item in line)
            {
                Console.WriteLine($"{item.ID} {item.FirstName} {item.LastName}");
            }

            Console.ReadKey();
        }
    }
}
