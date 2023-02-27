using System;
using System.Data;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace HelloWorld
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta"); 
        }

        public override void MakeSpacialDish()
        {
            Console.WriteLine("The Chef makes pizza");
        }
    }
}