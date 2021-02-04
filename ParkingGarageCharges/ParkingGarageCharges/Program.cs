using System;

namespace ParkingGarageCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCustomers;
            double hours;
            double total = 0.0;
            Console.WriteLine("Please enter how many customers parked in the garage yesterday");
            numberOfCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfCustomers; i++)
            {
                Console.WriteLine("Please enter how many hours Customer {0} parked", i);
                hours = Convert.ToDouble(Console.ReadLine());
                Customer cust = new Customer(hours);
                Console.WriteLine("Customer {0} parking charges are: {1:C2}", i, cust.CalculateCharges());
                total += cust.CalculateCharges();
            }
            Console.WriteLine("Total parking charges for all customers from yesterday: {0:C2}", total);
            Console.ReadLine();
        }
    }

}
