using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8";
            Console.WriteLine("Nama\t\t: Hafit Abekrori" + "\nNIM\t\t: 19.11.2765" + "\nKelas\t\t: 19-S1IF-03\n\n");

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.nik = "123-234-345";
            karyawantetap.nama = "Michael Suyama";
            karyawantetap.gajibulanan = 4000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.nik = "123-321-346";
            karyawanharian.nama = "Sam";
            karyawanharian.jumlahjamkerja = 8;
            karyawanharian.upahperjam = 25000;

            Sales sales = new Sales();
            sales.nik = "123-333-347";
            sales.nama = "Ray";
            sales.jumlahpenjualan = 30;
            sales.komisi = 20000;


            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int no = 1;
            
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}.Nama\t\t: {1} \n  NIK\t\t: {2} \n  Gaji\t\t: {3:N0}",no,karyawan.nama,karyawan.nik,karyawan.Gaji);

                no++;
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
