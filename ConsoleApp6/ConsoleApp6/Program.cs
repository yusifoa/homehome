using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nurlan Faiq  Emil Tural Yusif";
            Console.WriteLine(ReturnString("Nurlan Faiq  Emil Tural Yusif"));
        }

       static string ReturnString(string name)
        {
            string[] namearray = name.Split(' ');
            string b = "";
            foreach (var item in namearray)
            {

                for (int i = item.Length - 1; i >=  0; i--)
                {
                    b = b + item[i];
                }
                b = b + " ";
            }
            return b;
        }
    }
}
