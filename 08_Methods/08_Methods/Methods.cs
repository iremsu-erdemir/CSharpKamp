using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("1.Müşterİ Ali Yıldız");
            //    Console.WriteLine("2.müşteri yusuf can");
            //    Console.WriteLine("3.müşteri yunus emre");
            //    Console.WriteLine("4. müşteri merve çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen Paremetreli Metotlar

            //void WriteMethods(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethods("Yusuf Can YILDIRIM");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri : " + " " + name + " " + surName);
            //}

            //customerCard("yusuf can", "yıldırım");
            //customerCard("can", "yıldırım");
            #endregion

            #region Geriye Değer Döndürmeyen Int Paremetreli Metotlar

            //void Sum1(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum1(12, 23, 56);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse YILDIRIM";
            //}

            //CustomerName(); 

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "yıldırım";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Paremetreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " Başkent : " + capital + " Bayrak :" + flagColor;
            //    return cardInfo;
            //}

            ////Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı Beyaz"));

            //string x, y, z;
            //Console.Write("Ülke adını giriniz :");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz :");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz :");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Paremetreli Metotlar

            //int Sum1(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum1(23, 34));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result <= 50)
            //    {
            //        return student + " " + "Dersten kaldı" + " Ortalamanız :" + result;
            //    }
            //    else
            //    {
            //        return student + " " + "Dersten Geçtiniz" + " Ortalamanız :" + result;
            //    }
            //}

            //Console.Write(ExamResult("yusuf",23,56,89));
            #endregion
            Console.Read();
        }
    }
}