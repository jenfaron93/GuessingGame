using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithList
{
   class Program
   {
      static void Main(string[] args)
      {
         //data source for customers
         List<Customer> customers = new List<Customer>
         {
            new Customer{ First= "Joe", Last= "Smith", State = "Missouri" },
            new Customer{ First= "Betty", Last= "Jones", State = "California" },
            new Customer{ First= "Jane", Last= "Green", State = "California" },
            new Customer{ First= "Bobby", Last = "Brown", State = "California" },
            new Customer{ First= "Linda", Last="Avery", State="Alaska" } };

         //query 1- customers only
         IEnumerable<string> stateQuery =
            from cust in customers
            where cust.State == "California"
            select cust.First + " " + cust.Last;

         foreach(var a in stateQuery)
         {
            Console.WriteLine("Customer name is: {0}", a);
         }

         Console.ReadKey();

         

      
      }
   }
}
