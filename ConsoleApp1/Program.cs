using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Картинка к = new Картинка(6, 8, "fgdgf", "rtgfdsgxf", "rtfdgf");
            Музичний_твір к2 = new Музичний_твір("tghfhg", "yhgfhgf", "vhjuuj", "ghfvhcgf");
            МузиТвірДляОрк к3 = new МузиТвірДляОрк("jhnbjmn", "hjgfhgf", "ujhgfuyhg", "erfds", 67);

            Console.WriteLine(к);
            Console.WriteLine(к2);
            Console.WriteLine(к3);


            Console.ReadKey();
        }
    }
}
