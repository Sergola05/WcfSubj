using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfSubj;

namespace WcfSubj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1 client = new Service1();
            string result = client.GetMessage();
            Console.WriteLine(result);
        }
    }
}
