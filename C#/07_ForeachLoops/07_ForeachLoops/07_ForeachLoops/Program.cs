using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "ankara", "varşova", "istanbul", "roma", "budapeşte" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 56, 78, 6, 55, 34, 23, 432 };

            ////Dizideki çift sayıları listeleme

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Bir dizinin içerisindeki sayıların toplamı 

            //int[] numbers = { 1, 2, 3, 56, 78, 6, 55, 34, 23, 432 };

            //int toplam = 0;

            //foreach (int number in numbers)
            //{
            //    toplam = number + toplam;
            //}

            //Console.WriteLine(toplam);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3, 4,5
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# eğitim kampı sınav uyglaması *****");
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var :");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci sisimlerini ve not ortalamalarını sakliyacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz :");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci öğrenci için 3 sınav girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz :");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları 
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması :  {studentExamAvg[i]}");

                //Öğrencilerinin ortalamasını geçip kalma durumları
                if (studentExamAvg[i] < 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
                }
                Console.WriteLine("------------------------------");
            }


            #endregion

            Console.Read();
        }
    }
}