namespace PrinCompanyInformation
{
    using System;

    class PrinCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name:");
            string companyName = Console.ReadLine();
            Console.Write("Enter company address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter fax number:");
            string faxNumber = Console.ReadLine();

            if (faxNumber == "")
            {
                faxNumber = ("No fax");
            }
            Console.Write("Enter web site:");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name:");
            string managerFirst = Console.ReadLine();
            Console.Write("Manager last name:");
            string managerLast = Console.ReadLine();
            Console.Write("Manager age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Menager phone number:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel: {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.Write("Manager: {0}", managerFirst);
            Console.Write(" {0}", managerLast);
            Console.Write(" (age: {0}", age);
            Console.Write("tel: {0})", managerPhone);
        }
    }
}