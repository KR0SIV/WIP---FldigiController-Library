using System;
using XmlRpc;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FldigiWrapper
{

    public class FlControl
    {

        public static string Url = "http://localhost:7362";

        public static void Test(String xmlcommand)
        {
            XmlRpcClient client = new XmlRpcClient();
            client.Url = Url;
            //client.Path = "common";

            XmlRpcRequest requestCreate = new XmlRpcRequest(xmlcommand);
            //XmlRpcResponse responseCreate = client.Execute(requestCreate);
            client.Execute(requestCreate); //xml malformed error
            client.WriteRequest(Console.Out);
            Console.ReadKey();
        }
    }
}