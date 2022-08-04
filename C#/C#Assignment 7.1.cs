using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {


                string text = System.IO.File.ReadAllText(@"C:\test\text files\bhavya.txt");
                System.Console.WriteLine("Contents of text file = {0} ", text);
                string[] lines = System.IO.File.ReadAllLines("C:\test\text files\bhavya.txt");
                System.Console.WriteLine("Contents of text file2 = ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t " + line);
                }
                Console.WriteLine("press any key to exit.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string rootdir = @"C:\test\text files";
            string[] files = Directory.GetFiles(rootdir);
            Console.WriteLine(string.Join(Environment.NewLine, files));
            string[] dirs = Directory.GetDirectories(rootdir);
            string[] subdir = Directory.GetDirectories(rootdir);
            Console.WriteLine(string.Join(Environment.NewLine, dirs));
            DirectoryInfo directoryInfo = new DirectoryInfo(rootdir);
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Directory already exsits");
            }
            directoryInfo.Create();
            Console.WriteLine("Directory created");
            FileInfo fileinfo = new FileInfo(@"C:\test\text files\bhavya.txt");
            StreamWriter streamWriter = fileinfo.CreateText();
            streamWriter.WriteLine("file created");
            streamWriter.WriteLine("welcome to c#");
            streamWriter.Close();
            StreamReader streamReader = fileinfo.OpenText();
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
            System.Console.ReadKey();
        }    
        
    }
}
