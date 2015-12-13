using System;

    class PrintCompanyInfo
    {
        static void Main()
        {

            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            object companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Fax number: ");
            object faxNumber=Console.ReadLine();
                    
                Console.Write("Web site: ");
                object webSite = Console.ReadLine();
                Console.Write("Manager First Name: ");
                string managerFirstName = Console.ReadLine();
                Console.Write("Manager Last Name: ");
                string managerLastName = Console.ReadLine();
                Console.Write("Manager Age: ");
                sbyte managerAge = sbyte.Parse(Console.ReadLine());
                Console.Write("Manager phone: ");
                long managerPhone = long.Parse(Console.ReadLine());

                Console.WriteLine("Company name: "+companyName);
                Console.WriteLine("Company address: "+companyAddress);
                Console.WriteLine("Phone number: {0:(+359) ### ## ## ##}",phoneNumber);
                Console.WriteLine("Fax number: "+faxNumber);
                Console.WriteLine("Web site: http://"+webSite);
                Console.WriteLine("Manager first name: "+managerFirstName);
                Console.WriteLine("Manager last name: "+managerLastName);
                Console.WriteLine("Manager age: "+managerAge);
                Console.WriteLine("Manager phone: {0: (+359) # ### ## ## ##}",managerPhone);
               
            }  
        }


