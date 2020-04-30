using System;
using System.Collections.Generic;

namespace Generics
{
    public static class HashSet
    {
        public static void HashSetStructure()
        {
            //HashSets
            var hashSet1 = new HashSet<int> { 1, 2, 3 };
            var hashSet2 = new HashSet<int> { 2, 3, 4 };
            var hashSet3 = new HashSet<int> { 4, 5, 6 };

            hashSet1.UnionWith(hashSet3);
            hashSet1.IntersectWith(hashSet2);

            var hashSet = new HashSet<Employee>
            {
                new Employee("Felipe", 25),
                new Employee("Felipe", 25)
            };

            foreach (var i in hashSet)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");

        }

    }
}