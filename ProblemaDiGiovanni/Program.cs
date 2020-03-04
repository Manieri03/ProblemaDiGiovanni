using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiGiovanni
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("Input.txt"))
            {
                string line;
                using (StreamReader sr = new StreamReader("Input.txt", Encoding.UTF8))
                {
                    line = sr.ReadLine();

                }
                using (StreamWriter sw = new StreamWriter("Output.txt", false, Encoding.UTF8))
                {

                    int i = 0;
                    do
                    {

                    int lunghezzanumero = 0;
                        do
                        {
                            lunghezzanumero ++;

                            i++;
                        } while (line[i] != '1');

                        string n = line.Substring(i + 1, lunghezzanumero);
                        int n1 = int.Parse(n);

                        string numero = line.Substring(i + lunghezzanumero + 1, n1);
                        sw.WriteLine(numero);
                        i += 1 + lunghezzanumero + n1;

                    } while (line[i] != '*');

                }


            }

        }
    }
}
