using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company adress: ");
            string companyAdress = Console.ReadLine();

            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();

            Console.Write("Web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();

            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();

            string managerFullName = managerFirstName + " " + managerLastName;

            if (faxNumber == "")
            {
                faxNumber = "(no fax)";
            }

            
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAdress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})",managerFullName, managerAge, managerPhone);


        }
    }
}
