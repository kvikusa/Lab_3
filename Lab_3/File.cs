using System;
using System.IO;

namespace Lab_3
{
    public class FileTax
    {
        //Метод для заполнения бинарного файла случайными числами
        public static void BinFile(string fileBin, int count)
        {
            try
            {
                FileStream file = new FileStream(fileBin, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(file);

                Random random = new Random();
                Console.WriteLine("Число в файле: ");
                for (int i = 0; i < count; i++)
                {
                    int rndNum = random.Next(0, 101);
                    Console.WriteLine(" " + rndNum);
                    bw.Write(rndNum);
                }
                Console.WriteLine("\n Бинарный файл заполнен случайными числами");
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла  ошибка при записи в бинарный файл: " + ex.Message);
            }
        }

        public static void FileTxt(string filetxt, int count)
        {
            try
            {
                Random random = new Random();

                using (StreamWriter writer = new StreamWriter(filetxt))
                {
                    Console.WriteLine("Число в файле: ");
                    for (int i = 0; i < count; i++)
                    {
                        int rndNum = random.Next(1, 101);
                        writer.WriteLine(rndNum); // Заполнить числами от 1 до 100
                        Console.WriteLine(" " + rndNum);
                    }
                    Console.WriteLine("\n Бинарный файл заполнен случайными числами");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла  ошибка при записи в файл: " + ex.Message);
            }

        }

        // Метод для нахождения наибольшего значения модулей компонент с нечетными номерами - задача 4
        public static int FindMax(string fileName)
        {
            int max = int.MinValue;

            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int index = 1; // Начинаем с 1, так как нумерация с 1
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();

                    // Проверяем только элементы с нечетными индексами
                    if (index % 2 == 1)
                    {
                        int absValue = Math.Abs(number);
                        if (absValue > max)
                        {
                            max = absValue;
                        }
                    }
                    index++;
                }
            }
            return max;
        }
        //нахождение среднее арифметического числа - задача 6
        public static double SredArif(string fileName)
        {
            int sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sum += int.Parse(line);
                    count++;
                }
            }

            return count > 0 ? (double)sum / count : 0;
        }
    }
} 