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
    }
}
