using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FldigiWrapper; 

namespace LibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //flControl.Connect();
            //flControl.MainTx();
            //flControl.Command("FldigiVersion");

            FlControl.Test("main.tx");
        }
    }
}
