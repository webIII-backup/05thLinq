using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            string keuze = "";
            while (keuze != "99")
            {
                Console.WriteLine("\n\n-------------LINQ Menu--------------");
                Console.WriteLine("1. Step 1: Extension methods.");
                Console.WriteLine("2. Step 2: Enkele eenvoudige Linq operatoren.");
                Console.WriteLine("3. Step 3: Where en lambda expressies");
                Console.WriteLine("4. Step 4: Select en var/anonieme types");
                Console.WriteLine("5. Step 5: Nog meer handige LINQ operatoren");
                Console.WriteLine("6. Step 6: Expression bodied members");
                Console.WriteLine("7. Oefeningen");
                Console.WriteLine("99. Exit.");
                Console.Write("Enter your choice : ");
                keuze = Console.ReadLine();
                if (keuze != "99")
                {
                    Type type = Type.GetType("Linq.Step" + keuze);
                    if (type != null)
                    {
                        Object o = Activator.CreateInstance(type);
                        type.GetMethod("Execute").Invoke(o, null);
                    }
                }
            }
        }
    }
}

