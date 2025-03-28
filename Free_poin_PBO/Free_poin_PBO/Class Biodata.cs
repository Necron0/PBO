using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_poin_PBO
{
    class Biodata
    {
        public string Nama;
        public string Prodi;
        private int _Nim;
        public Biodata(string nama, string prodi, int nim)
        {
            Nama = nama;
            Prodi = prodi;
            this.nim = nim; 
        }

        public int nim
        {
            get { return _Nim; }
            set
            {
                string Value = value.ToString();
                
                if (Value.StartsWith("10") && Prodi == "Sistem informasi")
                {
                    Console.WriteLine("Nim dan prodi sesuai");
                    
                }
                else if (Value.StartsWith("20") && Prodi == "Teknologi informasi")
                {
                    Console.WriteLine("Nim dan Prodi sesuai");
                    
                }
                else if (Value.StartsWith("30") && Prodi == "Informatika")
                {
                    Console.WriteLine("Nim dan Prodi sesuai");
                    
                }
                else
                {
                    Console.WriteLine("\nNim dan Prodi tidak sesuai");
                }
                _Nim = value;
            }   
        }
    }

}
