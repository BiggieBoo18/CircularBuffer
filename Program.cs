using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCircularBuffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularBuffer<int> buffer = new CircularBuffer<int>(4);
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.put(1);
            Console.WriteLine($"count={buffer.Count}");
            buffer.put(2);
            Console.WriteLine($"count={buffer.Count}");
            Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.put(3);
            Console.WriteLine($"count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.put(4);
            Console.WriteLine($"count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.put(5);
            Console.WriteLine($"count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.put(6);
            Console.WriteLine($"count={buffer.Count}");
            //Console.WriteLine($"get={buffer.get()} count={buffer.Count}");
            buffer.show();
            Console.ReadKey();
        }
    }
}
