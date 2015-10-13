using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using System.Security;

namespace Utente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserire username e password in caso di esecuzione su sistemi successivi a windows 7 usare la mail");
            String username = Console.ReadLine();
            String password = Console.ReadLine();
            //http://www.blackwasp.co.uk/SecureStringTextBox.aspx
            //https://msdn.microsoft.com/it-it/library/system.security.securestring(v=vs.110).aspx
            //SecureString password = new SecureString();

            bool valid = false;
            using (PrincipalContext context = new PrincipalContext(ContextType.Machine))
            {
                valid = context.ValidateCredentials(username, password);
            }

            Console.WriteLine(username + " " + password + valid);
            Console.ReadLine();
        }
    }
}
