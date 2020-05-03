using Generics.Module_2;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1
            //Queue.FifoStructure();
            //Stack.LifoStructure();
            //HashSet.HashSetStructure();
            //Link.LinkedList();
            //Map.Dictionary();

            //Module 2
            //var buffer = new CircularBuffer<double>();
            var buffer = new Buffer<double>();
            ProcessInput(buffer);

            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }

            ProcessBuffer(buffer);
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty())
            {
                sum += buffer.Read();
            }

            Console.WriteLine(sum);
        }

        public static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (double.TryParse(input, out var value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
