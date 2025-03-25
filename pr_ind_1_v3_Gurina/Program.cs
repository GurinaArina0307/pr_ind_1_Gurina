using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace pr_ind_1_v3_Gurina
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "file.txt";
            try
            {
                var lines = File.ReadAllLines(file);

                foreach (var line in lines)
                {
                    Stack<char> stack = new Stack<char>(line.ToCharArray());

                    Console.WriteLine(new string(stack.ToArray()));
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка при считывание из файла!");
            }

            Console.ReadKey();
        }
    }
}
