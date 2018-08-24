using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WordCountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid text path: ");
            string filename = Console.ReadLine();
            StreamReader read = new StreamReader(filename);

            string contents = read.ReadToEnd();

            string [] words = contents.Split(' ');

            int count = 0;

            foreach(string c in words)
            {
                count++;
            }


            Console.WriteLine("Word Count: {0}",count);


        }
    }
}
