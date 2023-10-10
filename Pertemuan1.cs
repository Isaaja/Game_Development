using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   /* Output
                Console.WriteLine("Hello World");
            */
            /* Input
                string name;
                name = Console.ReadLine();
            */
            /* penggunaan \t , \n dan \r
                string devisiGame;
                devisiGame = "hehesiu \tnguehhe \n"; // \t itu kayak tab kalau \n itu spasi atau c++ endl kalau \r itu kolom
                Console.WriteLine(devisiGame);
            */
            /* Penggunaan float

                const float phi = 3.14f;
                Console.WriteLine(phi);
            */
            /* Penggunaan var

                var devisi = true; //bisa universal , contoh kalau masukin int,string,float dll ttp bisa (flexibel)
                Console.WriteLine(devisi);
            */
            /* Klo ingin menggunakan tanda petik

                string devisiGame1 = "\"asdsads\""; //biar ada tanda petiknya xixixi
                Console.WriteLine(devisiGame1); 
            */

            /* Penggunaan \r dan \n

                string devisiGame2 = "Januari \r\nFebruari \r\nMaret"; //contoh dari \r\n 
                Console.WriteLine(devisiGame2);

            */

            //ini komentar

            /* Penggunaan int float double dan string
             int umur = 20;
             float hehe= 1.4f;
             double haha= 33.3;
             string huhu = "xxixiix";
            */

            /* menjadikan sebuah kalimat menjadi huruf kapital
                string txt = "Selamat Pagi isa";
                string txtUpper = txt.ToUpper();
                Console.WriteLine(txtUpper);

            */
            /* menjadikan sebuah kalimat menjadi huruf kecil

                string txt = "Selamat pagi isa";
                string txtLower = txt.ToLower();
                Console.WriteLine(txtLower);
            */
            /* mengetahui panjang karakter dari suatu string

                string txt = "Selamat pagi isa";
                Console.WriteLine("Panjang karakter dari txt adalah : " + txt.Length);
            */
            /* penggunaan string interpolation

                string firstName = "isa iant";
                string Lastname = "maulana";
                string nama = $"My Full Name is : {firstName} {Lastname}";
                Console.WriteLine(nama);
            */
            /* DayOfWeek untuk menampilkan hari kalau day tanggal 

                var date = DateTime.Now;
                string perasaan = "senang";
                string namasaya = "Ucup";
                Console.WriteLine($"Hari ini {date.DayOfWeek}, {namasaya} {perasaan} karena mengikuti pelatihan btng");

            */
            /*

                ini untuk angka kyk 30/10/2023
                
                var date = DateTime.Now;
                var day = date.Day;
                var month = date.Month;
                var year = date.Year;
                
                ini untuk huruf kyk Maret
                
                var month1 = date.ToString("MMMM");
                Console.WriteLine(month1);
                var day1 = date.ToString("dddd");
                Console.WriteLine(day1);
                var year1 = date.ToString("yyyy");
                Console.WriteLine(year1);

            */
            /* penggunaan boolean

                bool benar = true;
                bool salah = false;

                if (benar == true)
                {
                    Console.WriteLine("awekhbasdbsadk");
                }
                else if (salah == false)
                {
                    Console.WriteLine("kwe salah pepek");
                }
            */
            /* Konversi Tipe Data

                Float ke Int

                float angka1 = 3.15f;
                int angka2 = (int)angka1; // float ditimpa pakai int
                Console.WriteLine(angka2);
            
                Int ke String

                int angkaToString = 99;
                Console.WriteLine($"Hasil dalam String adalah : {angkaToString.ToString()}"); // mengkonversikan int ke string
           
                String ke Int
                
                string pertama = "10";
                string kedua = "89";

                int sum = int.Parse(pertama) + int.Parse(kedua);
                Console.WriteLine(sum);
            */
            /* Operator Aritmatika
               
                var penjumlahan = 10 + 5;
                var pengurangan = 10 - 5;
                var perkalian = 10 * 5;
                var pembagian = 10 / 5;
                var modulus = 10 % 3;
                Console.WriteLine("Hasil penjumlahan    : " + penjumlahan);
                Console.WriteLine(pengurangan);
                Console.WriteLine(perkalian);
                Console.WriteLine(pembagian);
                Console.WriteLine(modulus);
            */
            /* Operator Penugasan

                a += 5 itu sama juga dengan a = a + 5
                a -= 5 itu sama juga dengan a = a - 5
                a *= 5 itu sama juga dengan a = a * 5
                a /= 5 itu sama juga dengan a = a / 5
                a %= 5 itu sama juga dengan a = a % 5
            */
            /* Operator perbandingan
               
                ( ==, !=, >,<, <=, >=)
            */
            /* Operator Logika

                (&&, ||)

            contoh penggunaan && ( true dan true = true, true dan false = false)

            if (5 == 5 && 5 == 5)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            contoh penggunaan || (true dan true = true , true dan false = true)

            if (5 == 5 || 5 == 5)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            */
            /* Array

                
                string[] divisiDNCC = { "Game", "Data Analyst", "Jaringan" };
                Console.WriteLine(divisiDNCC[0]);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(divisiDNCC[i]);
                }
            */
            /* Array 2D
            
                int[,] number = { { 1, 2 }, { 3, 4 } };
                Console.WriteLine(number[0, 1]);
            */
            /* Array 3D

                //array 3D
                int[,,] newnumber = { { { 1, 2, 3 }, { 1, 3, 2 } }, { { 2, 3, 1 }, { 3, 2, 3 } } };
                Console.WriteLine("Hasil ini adalah " + newnumber[0, 0, 1]);
            */
            /* List

                var names = new List<string> { "Game", "Data Analyst", "Jaringan" };
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine("Hasil List ini adalah " + names[i]);
                }

                List<int> angka = new List<int>();
                angka.Add(1);
                angka.AddRange(new int[3] { 4, 5, 6 });
                angka.Remove(1);
                angka.RemoveAt(0);
                angka.IndexOf(3);
                Console.WriteLine(angka.Contains(10));
                Console.WriteLine(angka.Count);
            */
            /* Switch
            
                int nilai1 = 80;
                switch(nilai1){
                    case >= 85 :
                    Console.WriteLine("Grade A");
                    break;
                    case >= 80 :
                    Console.WriteLine("Grade AB");
                    break;
                    case >= 70 :
                    Console.WriteLine("Grade B");
                    break;
                    case >= 65 :
                    Console.WriteLine("Grade BC");
                    break;
                    case >= 60 :
                    Console.WriteLine("Grade C");
                    break;
                    case >= 50 :
                    Console.WriteLine("Grade D");
                    break;
                    case < 50 :
                    Console.WriteLine("Grade E");
                    break;

                }

            */
            /*foreach

                foreach (var a in angka)
                {
                    Console.Write(a + " "); // sejajar
                }
                Console.WriteLine("\n"); //agar kebawah

                // do while
                int j = 0;
                do
                {
                    Console.WriteLine(j);
                    j++;
                } while (j < 3);
            */
            /* For

                for(int i =0; i <5;i++){
                    Console.WriteLine(i + " ");
                }

            */
            /* While

                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine(i);
                    i++;
                }
            */
            /* Do While

                int i = 0;
                do{
                    Console.WriteLine(i);
                    i++;
                }while(i < 5);
            */
            /* Break

                for (int i = 0; i < 5; i++){
                    Console.WriteLine(i);
                    if (i==1){
                        break;
                    }
                }
            */
            /* Continue

                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(i); // tercetak angka genap
                }

                for (int j = 0; j < 5; j++)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(j); // tercetak angka ganjil
                }
            */
            //Tampil(); => Output dari fungsi Tampil




        }
            /* Function
                public static void Tampil(){
                    Console.WriteLine("Game");    
                }
            */
    }
}