using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = "CNF";
            string id = "123456";
            string rede = "GETNET";
            string nsu_ctf = "476154";
            string finalizacao = "12345";
            string final = "0";

            StreamWriter sw = new StreamWriter("c:\\Tef_Dial\\req\\IntPos.001");

                sw.WriteLine("000-000 = " + header);
                sw.WriteLine("001-000 = " + id);
                sw.WriteLine("010-000 = " + rede);
                sw.WriteLine("012-000 = " + nsu_ctf);
                sw.WriteLine("027-000 = " + finalizacao);
                sw.WriteLine("999-999 = " + final);
                sw.Close();
        }
    }
}