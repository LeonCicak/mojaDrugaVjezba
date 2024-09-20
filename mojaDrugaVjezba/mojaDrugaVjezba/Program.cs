using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojaDrugaVjezba
{
    internal class Program
    {
        static void Main(string[] args)
            int x, y, z, a;
        Console.Write("upisi prvi broj:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("upisi drugi broj:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("upisi treci broj:");
            z = Convert.ToInt32(Console.ReadLine());
            a = x + y + z;
            Console.WriteLine(x + " plus " + y +
                " plus " + z + " jednako je " + a);
            Console.ReadKey();
        {
        }
    }
}
