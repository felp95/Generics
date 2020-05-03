using System;
using System.Collections.Generic;

namespace Generics
{
    public static class Link
    {
        public static void LinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            var first = linkedList.First;
            linkedList.AddAfter(first, 5);
            linkedList.AddBefore(first, 10);

            foreach (var i in linkedList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------");
        }
    }
}