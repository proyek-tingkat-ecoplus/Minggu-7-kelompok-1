using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpmodul7_kelompok_1;

namespace Minggu_7_kelompok_7
{
        internal class DataMahasiswa_1302223148
        {
            public detail_nama nama { set; get; }
            public string nim;
            public string fakultas { set; get; }

            public void getNama()
            {
                Console.WriteLine(this.nama);
            }

            public void getNim()
            {
                Console.WriteLine(nim);
            }

            public void getFalkultas()
            {
                Console.WriteLine("here");
                Console.WriteLine(fakultas);
            }

            public void details()
            {
                Console.Write("Nama : " + nama.depan + " " + nama.belakang);
                Console.Write(" , NIM : " + nim);
                Console.Write(" , Falkultas : " + fakultas);
            }
        }

        internal class detail_nama
        {
            public string depan;
            public string belakang;
        }
    }

