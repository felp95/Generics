using System;
using System.Collections.Generic;

namespace Generics
{
    public static class Queue
    {
        public static void FifoStructure()
        {
            //FIFO Data structure
            var line = new Queue<Employee>();

            line.Enqueue(new Employee("Renanzinho", 10));
            line.Enqueue(new Employee("Rogerinho", 10));

            while (line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee);
            }

            Console.WriteLine("----------------");
        }
    }
}