using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personCount = 0;

            

            string input = Console.ReadLine();

            if (input.StartsWith("--personcount "))
            {
                string countStr = input.Substring("--personcount ".Length);
                if (int.TryParse(countStr, out int count))
                {
                    personCount = count;
                }
                else
                {
                    Console.WriteLine("Virhe: Syötä kelvollinen numero.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Virhe: Syötä '--personcount' ja siihen liittyvä numero.");
                return;
            }

            if (personCount < 1)
            {
                Console.WriteLine("Virhe: '--personcount' arvon on oltava vähintään 1.");
                return;
            }

            for (int i = 0; i < personCount; i++)
            {
                var name = Faker.Name.FullName();
                Console.WriteLine(name);

                var address = Faker.Address.StreetAddress();
                Console.WriteLine(address);

                var usPassport = Faker.Identification.UsPassportNumber();
                Console.WriteLine(usPassport);

                var ssn = Faker.Identification.SocialSecurityNumber();
                Console.WriteLine(ssn);

                Console.WriteLine();
            }
        }
    }
}
