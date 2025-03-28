using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_poin_PBO
{
    class Judul_Buku
    {
        private string _judul;
        public string Judul;
        
        public string judul
        {
            get { return _judul; }
            set { _judul = value; }
            
        }
        public void melihat(string buku)
        {
            _judul = buku;
            Console.WriteLine($"Anda sedang melihat buku berjudul : {buku}");
        }

        public void ganti(string buku)
        {

            Console.WriteLine($"Buku berjudul {_judul} akan anda ganti menjadi");
            string ganti = Console.ReadLine();
            Console.WriteLine($"Buku yang berjudul {_judul} telah terganti {ganti}");
        }
    }

}
