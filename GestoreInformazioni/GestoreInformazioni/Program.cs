using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq;

namespace GestoreInformazioni
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string @namespace = "GestoreInformazioni.fornitori";

            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == @namespace
                    select t;
            q.ToList().ForEach(t => Console.WriteLine(t.Name));
            Console.ReadLine();
        }
    }
}
