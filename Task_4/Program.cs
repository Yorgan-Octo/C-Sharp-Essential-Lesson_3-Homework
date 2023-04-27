using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string proKey = "PR517UA";
            string expertKey = "EX517UA";

            Console.Write("Write Key Product: ");
            string namKey = Console.ReadLine();


            DocumentWorker documentWorker = new DocumentWorker();

            if (namKey == proKey)
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (namKey == expertKey)
            {
                documentWorker = new ExpertDocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            Console.ReadKey();
        }
    }
}
