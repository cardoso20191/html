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
            string header = "CRT";
            string id = "123456";
            string v_total = "000000000500";
            string final = "0";

            StreamWriter sw = new StreamWriter("c:\\Tef_Dial\\req\\IntPos.001");

                sw.WriteLine("000-000 = " + header);
                sw.WriteLine("001-000 = " + id);
                sw.WriteLine("003-000 = " + v_total);
                sw.WriteLine("999-999 = " + final);
                sw.Close();
        }
    }
}