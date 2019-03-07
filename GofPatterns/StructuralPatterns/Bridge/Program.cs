using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction and Set ConcreteImplementor
            Customers customers = new Customers("Chicago") { Data = new CustomersData() };

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show(); 
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
  
            customers.ShowAll();
  
            // Wait for user
            Console.ReadKey();
        }
    }
}
 
 