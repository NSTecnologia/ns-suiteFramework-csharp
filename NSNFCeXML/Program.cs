using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSNFCeXML.GerarXML;

namespace ProgramMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string conteudo = NFCeXML.GerarNFCeXML();
            Console.WriteLine(conteudo);
        }
    }
}
