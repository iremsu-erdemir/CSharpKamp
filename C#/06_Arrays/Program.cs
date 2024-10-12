using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu
            //adana,sivas,erzincan
            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı];


            /*string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Yeşil";
            colors[2] = "Mavi";
            colors[3] = "Mor";
            */


            /*string[] cities = new string[5];
            cities[0] = "Sivas";
            cities[1] = "Erzincan";
            cities[2] = "Tokat";
            cities[3] = "Malatya";
            cities[4] = "Edirne";
            Console.WriteLine(cities[0]);
            */


            /* int[] numbers=new int[10];
             numbers[0] = 10;
             numbers[1] = 20;    
             numbers[2] = 30;    
             numbers[3] = 50;
             numbers[7] = 100;
             Console.WriteLine(numbers[7]); 
            */

            /* string[] cities = { "prag", "roma", "sivas" };
             Console.WriteLine(cities[0]);   
            */

            #region Dizideki tüm elemanları listeleme


            /*string[] renkler = { "mavi", "mor", "kırmızı", "siyah", "beyaz" };
            for (int i = 0; i < renkler.Length; i++) { 
               Console.WriteLine(renkler[i]);   
            } 
            */




            /*
            int[] number = { 10, 23, 45, 67, 89, 100,99, 98 };
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 3 == 0)
                {
                    Console.WriteLine(number[i]);

                }
            }
            */

            /*
            char[] symbols = { 'A', 'B', 'C' };
            for (int i = 0; i < symbols.Length; i++) { 
            
            Console.WriteLine(symbols[i]);
            
            }

            */


            /*int[] myArray = { 47, 85, 95, 41, 25, 635, 100, 789, 86 };
            int maxNumber= myArray[0];
            for (int i = 0; i <myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];

                }
            }

            Console.WriteLine(maxNumber);
            */

            /*
            string[] persons = { "ali", "ahmet", "buse", "cem" };
            Console.WriteLine(persons.Length);
            */

            /*   int[] numbers = { 1, 22, 3, 4, 89, 6, 7, 8, 9, 10 };
               Array.Sort(numbers);
               for (int i = 0; i < numbers.Length; i++) {
               Console.WriteLine(numbers[i]);
             }
            */



            /*int[] numbers = { 1, 22, 3, 4, 89, 6, 7, 8, 9, 10 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            */
            #endregion


            #region Dizi Metotlar


            /* 
            string[] people = { "Ali", "buse", "ayşegül", "irem" };
            int index = Array.IndexOf(people, "irem");
            Console.WriteLine(index);
            */


            /*
            int[] number = { 1, 2, 3 };
            Console.WriteLine( "dizinin en büyük elemanı: " + number.Max() + "\n" + "dizinin en küçük elemanı: "+ number.Min()); 

            */
            #endregion


            #region Kullanıcıdan Değer Alma 


            /* string[] cities = new string[5];
             for (int i = 0; i < cities.Length; i++) { 

             Console.Write($"lütfen  {i+1}. şehrini giriniz:  ");
                 cities[i]=Console.ReadLine();
             }
             Console.WriteLine();
             Console.WriteLine("--------------------");
             for (int i = 0; i < cities.Length; i++) {
                 Console.WriteLine(cities[i]);
             }

             */


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) { 
            //    sum+= numbers[i];  
            //}
            //Console.WriteLine(sum); 

            #endregion

            #region Tek ve Çift Sayılar Listeleme

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 99, 220 };
            Console.WriteLine("Çift sayılar: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
        }

    }

}
     #endregion