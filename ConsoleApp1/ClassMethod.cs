using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassMethod
    {
        public void GreetCountries(string inputFile, string outputFile, string path)
        {
            string content = "";
            string endPath = path + outputFile;
            try
            {
                using(StreamReader oSR = File.OpenText(path + inputFile))
                {
                    string country = "";
                    while((country = oSR.ReadLine()) != null)
                    {
                        content += "Saludos hasta "+ country + "!\n";
                    }
                    File.AppendAllText(endPath, content);
                    Console.WriteLine("File generated successfully!!!");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
