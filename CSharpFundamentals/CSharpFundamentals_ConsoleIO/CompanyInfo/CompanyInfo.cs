using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.Write("Address: ");
            Console.WriteLine(companyAddress);
            Console.Write("Tel. ");
            Console.WriteLine(phoneNumber);
            Console.Write("Fax: ");
            if (faxNumber == string.Empty)
            {
                Console.WriteLine("(no fax)");
            }
            else
            {
                Console.WriteLine(faxNumber);
            }
            Console.Write("Web site: ");
            Console.WriteLine(webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}