using System.Drawing;
using System.IO;
namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string file ="Rand.bin" ;
            FileTax.BinFile(file, 30);
            int znach = FileTax.FindMax(file);
            Console.WriteLine($"Наибольшее из значений модулей компонент с нечетными номерами -> {znach}");

            string file2 = "Task6.txt";
            FileTax.FileTxt(file2, 30);
            double srarif = FileTax.SredArif(file2);
            Console.WriteLine($"Среднее арифмитическое = {srarif}");

        }
    }
}
