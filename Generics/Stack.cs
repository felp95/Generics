using System;
using System.Collections.Generic;

namespace Generics
{
    public static class Stack
    {
        public static void LifoStructure()
        {
            //LIFO Data structure
            var stack = new Stack<Employee>();

            stack.Push(new Employee("Renanzinho", 10));
            stack.Push(new Employee("Rogerinho", 10));

            while (stack.Count > 0)
            {
                var employee = stack.Pop();
                Console.WriteLine(employee);
            }
            Console.WriteLine("----------------");

        }
    }
}