

using Free_poin_PBO;

class program
{
    static void Main(string[] args)
    {
        Judul_Buku buku1 = new Judul_Buku();
        buku1.melihat("Buku perang");
        buku1.ganti("buku perang");
        Biodata data1 = new Biodata("Stanley", "Sistem informasi", 2032);


        Console.WriteLine();
        Console.WriteLine("Nama : " + data1.Nama);
        Console.WriteLine("Prodi: " + data1.Prodi);
        Console.WriteLine("Nim  : " + data1.nim);
        Console.ReadLine();
    }
   
}