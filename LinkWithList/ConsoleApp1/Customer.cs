using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkWithList
{
   class Customer
   {
      public string First { get; set; }
      public string Last { get; set; }
      public string state;

      public string State
      {
         get
         {
            return state;
         }
         set
         {
            if (value == "Canada")
               throw new Exception("This is not a US State");
            else
               state = value;
         
         }
      }


   }
}
