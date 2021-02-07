using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek:
            //List<string> cities = new List<string>();
            //cities.Add("İStanbul");
            //Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.Add("İstanbul");
            cities2.Add("İzmir");
            cities2.Add("Ankara");
            Console.WriteLine(cities2.Count);
            for (int i = 0; i < cities2.Count; i++)
            {
                Console.WriteLine(cities2.Items[i]);
            }

            foreach (var city in cities2.Items)
            {
                Console.WriteLine(city);
            }

            /* Örnek :
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(0, "İrem");
            users.Add(1, "Ceren");

            Console.WriteLine(users.Count);

            foreach (var user in users)
            {
                Console.WriteLine(user.Value);
            }
            */

            MyDictionary<int, string> users2 = new MyDictionary<int, string>();
            users2.Add(0, "Kerem");
            users2.Add(1, "Beren");

            Console.WriteLine(users2.Count);

            foreach (var userKey in users2.Keys)
            {
                Console.WriteLine(userKey);
            }

            foreach (var userValue in users2.Values)
            {
                Console.WriteLine(userValue);
            }
        }
    }
}
