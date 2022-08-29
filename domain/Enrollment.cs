using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharp9
{
    public class Enrollment
    {
         public static void EnrollClient(ref List<IClient> clients)
        {
            Console.Write($"pls Enter your name: ");
            string name = "_";
            name = Console.ReadLine();
            Console.Write($"pls enter your familyname: ");
            string lastname = "_";
            lastname = Console.ReadLine();
            Console.WriteLine($"pls enter your subscribtion type: \n1. Normal");
            int subscribtionType = 0;
            subscribtionType = int.Parse(Console.ReadLine());
            if (subscribtionType == 1)
            {
                IClient newPerson = new NormalClient(name, lastname);
                clients.Add(newPerson);
            }
        }
        
    }
}