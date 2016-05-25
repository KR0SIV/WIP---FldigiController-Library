/*
 * KR0SIV's Convoluted C# Library Wrapper for FLdigi's XMLRPC Commands 
 * You will find problems with this application, it's not even finished
 * 
 * Pull requests are highly appreciated, I'm happy to implement code that will improve on this library wrapper
 * 
 */

using System;
using CookComputing.XmlRpc;


namespace FldigiController
{
    [XmlRpcUrl("http://localhost:7362")]   //address of the fldidi xmlrpc server
    public interface Flrpc : IXmlRpcProxy
    {
        [XmlRpcMethod("fldigi.name")] //Returns name of the program
        String FldigiName();

        [XmlRpcMethod("fldigi.version")] //Returns version of the program
        String FldigiVersion();

        [XmlRpcMethod("modem.getname")] //Returns name of current modem
        String ModemGetName();

        [XmlRpcMethod("modem.set_by_name")] //Sets the modem by a name string. It returns the pervious modem.
        String ModemSetbyName();

        [XmlRpcMethod("modem.set_by_id")] //Sets modem by the ID.
        int ModemSetbyId();

        [XmlRpcMethod("text.clear_rx")] //Clear rx text window
        String TextClearRx();

        [XmlRpcMethod("main.tx")] //Sets mode to transmit
        String MainTx();

        [XmlRpcMethod("main.get_trx_status")] //Grabs the current rx/tx status
        String MainGetTrxStatus();


    }

    public class flControl
    {
        public static void Connect()
        {
            Console.WriteLine("DEBUG: Called from FldigiController"); //Prints debug line to console
            Flrpc proxy = XmlRpcProxyGen.Create<Flrpc>();
            //            Console.WriteLine("Current Status " + proxy.MainGetTrxStatus());
            //            Console.WriteLine("DEBUG: Clearing text" + proxy.TextClearRx());
            //            Console.WriteLine("Version " + proxy.FldigiVersion());
            //            Console.WriteLine("DEBUG: Beginning Transmit" + proxy.MainTx());
            //            Console.WriteLine();
            //            Console.ReadLine();
        }
        public static void MainTx()
        {
            Flrpc proxy = XmlRpcProxyGen.Create<Flrpc>();
            Console.WriteLine(proxy.MainTx());
        }
        public static void FldigiVersion()
        {
            Flrpc proxy = XmlRpcProxyGen.Create<Flrpc>();
            Console.WriteLine(proxy.FldigiVersion());
        }
        public static void Command(string value)
        {
            if (value.Equals("MainTx")) 
            {
                flControl.MainTx(); //calls the maintx method
                Console.ReadKey();
            }
            if (value.Equals("FldigiVersion"))
            {
                flControl.FldigiVersion(); //call the fldigiversion method
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERROR: Command not found in method"); //placeholder
                Console.ReadKey();
            }
        }
    }
}
