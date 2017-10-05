using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            String strHostName = string.Empty; //getting the Host Name.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName); //Using Host Name.
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {1} : ", addr[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
