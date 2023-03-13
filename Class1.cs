public class KodeBuah
{
    public string getKodeBuah(string Buah) {
        switch (Buah)
        {
            case "Apel":
                return "A00";
            case "Aprikot":
                return "B00";
            case "Alpukat":
                return "C00";
            case "Pisang":
                return "D00";
            case "Paprika":
                return "E00";
            case "Blackberry":
                return "F00";
            case "Ceri":
                return "H00";
            case "Kelapa":
                return "I00";
            case "Jagung":
                return "J00";
            default:
                return "Kode Buah Tidak Ada";

        }
    }
}


