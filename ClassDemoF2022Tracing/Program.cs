using System;
using System.Xml;

namespace ClassDemoF2022Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConfiguration();

            AWorker worker = new AWorker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }

        private static void ReadConfiguration()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load("Config.xml");

            XmlNode portNode = configDoc.DocumentElement.SelectSingleNode("Port");
            if (portNode != null)
            {
                String str = portNode.InnerText.Trim();
                int serverPort = Convert.ToInt32(str);


                Console.WriteLine("Read serverport is " + serverPort);
            }

            XmlNode nameNode = configDoc.DocumentElement.SelectSingleNode("Name");
            if (nameNode != null)
            {
                String str = nameNode.InnerText.Trim();
                
                Console.WriteLine("Read server name is " + str);
            }
        }
    }
}
