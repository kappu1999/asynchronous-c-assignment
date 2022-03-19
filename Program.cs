using System;
using System.IO;
using System.Threading.Tasks;

namespace asynchronousassignment
{
    public class Program
    {
        static async Task <string[]> Read(string Filename)
        {
            var ReadData = await File.ReadAllLinesAsync(Filename);
            return ReadData; 
        }
        static async Task Write(string[] WriteData,string Filename)
        {
            await File.WriteAllLinesAsync(Filename, WriteData);
            System.Console.WriteLine("File A.txt data copy successfully in B.txt");
        }
        public static async Task Copy()
        {
            var Content = Read("A.txt");
            await Write(Content.Result,"B.txt");
        }
        public static void Main(string[] args)
        {
            Task task = Copy();       
        }
            
    }
}

