public abstract class Rekening
{
    public string NamaPemilik { get; set; }
    public string NomorRekening { get; set; }
    public double Saldo { get; set; }
    public Rekening(string namaPemilik, string nomorRekening, double saldo)
    {
        NamaPemilik = namaPemilik;
        NomorRekening = nomorRekening;
        Saldo = saldo;
    }
    public virtual void TarikDana(double jumlah)
    {
        if (Saldo >= jumlah)
        {
            Console.WriteLine("Penarikan Saldo Berhasil!");
        }
        if (Saldo == jumlah)
        {
            Console.WriteLine("Saldo Tidak Dapat Ditarik!");
        }
        if (Saldo <= jumlah)
        {
            Console.WriteLine("Saldo Anda Tidak Mencukupi");
        }
    }
    public virtual void SetorTunai(double jumlah)
    {
        Saldo += jumlah;
        Console.WriteLine($"{NamaPemilik} Telah Berhasil Menyetor Tunai Sebesar {jumlah}");
    }
    public virtual void Transfer(double jumlah)
    {
        if (Saldo >= jumlah)
        {
            Console.WriteLine("Selamat! Anda Telah Berhasil Transfer ke Rekening lain!");
        }
        if (Saldo == jumlah)
        {
            Console.WriteLine("Tidak Dapat Melakukan Transfer Saldo.");
        }
        if (Saldo <= jumlah)
        {
            Console.WriteLine("Slado Anda Tidak Mencukupi!");
        }
    }
}
public class RekeningTabungan : Rekening
{
    public RekeningTabungan(string NamaPemilik, string NomorRekening, double Saldo)
    {
        this.NamaPemilik = NamaPemilik;
        this.NomorRekening = NomorRekening;
        this.Saldo = Saldo;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selamat Datang di Bank Pelita!!!!!!");
    }
}
