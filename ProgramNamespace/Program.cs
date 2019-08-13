using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramNamespace
{
    public class Program
    {
        public static List<String> processData(
                                        IEnumerable<string> lines)
        {
            /* 
             * Do not make any changes outside this method.
             *
             * Modify this method to process `array` as indicated
             * in the question. At the end, return the size of the
             * array. 
             *
             * Do not print anything in this method
             *
             * Submit this entire program (not just this function)
             * as your answer
             */

             List<Tuple<string, string, string>> productList = new List<Tuple<string, string, string>>();
             List<String> retVal = new List<String>();

            foreach (string line in lines) {
                string [] arr =   line.Split(',');

                productList.Add(new Tuple<string, string, string>(arr[0], arr[1], arr[2]));
            } 
            foreach (Tuple<string,string,string> item in productList) {
                string library = item.Item2;
                Int32 versionNumber = Convert.ToInt32(item.Item3.Replace("v",""));
                var newItems = (from product in productList where product.Item2 == library select product).ToList();
                var isLatestVersion = (from items in newItems where Convert.ToInt32(items.Item3.Replace("v", "")) > versionNumber select items).ToList();
                if (!isLatestVersion.Count.Equals(0)) { 
                    retVal.Add(item.Item1);
                }
            }

            return retVal.Distinct().ToList();
        }

        static void Main(string[] args)
        {
            try
            {
                List<String> retVal = processData(
                                      File.ReadAllLines("input.txt"));
                File.WriteAllLines("output.txt", retVal);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
