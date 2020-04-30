using System;
using System.Collections.Generic;

namespace Generics
{
    public static class Map
    {
        public static void Dictionary()
        {
            var dictionary = new Dictionary<string, Employee>
            {
                {"Renan", new Employee("Renan", 30)},
                {"Rogerinho", new Employee("Rogerinho", 35)}
            };

            var renan = dictionary["Renan"];

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }

            Console.WriteLine("----------------");
        }
    }
}