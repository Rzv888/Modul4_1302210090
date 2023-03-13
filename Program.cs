using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        KodeBuah KodeBuah = new KodeBuah();
        string NamaBuah = "Paprika";
        string KodeNamaBuah = KodeBuah.getKodeBuah(NamaBuah);
        Console.WriteLine($"Kode Nama Buah {NamaBuah}:{KodeNamaBuah}");
    }
}
