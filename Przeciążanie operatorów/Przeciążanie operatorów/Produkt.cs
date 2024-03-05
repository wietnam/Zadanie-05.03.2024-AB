public class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int Ilość { get; set; }

    public Produkt(string nazwa, decimal cena, int ilość)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilość = ilość;
    }

    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}";
    }

    public static bool operator ==(Produkt a, Produkt b)
    {
        return a.Cena == b.Cena;
    }

    public static bool operator !=(Produkt a, Produkt b)
    {
        return a.Cena != b.Cena;
    }

    public static bool operator <(Produkt a, Produkt b)
    {
        return a.Cena < b.Cena;
    }

    public static bool operator >(Produkt a, Produkt b)
    {
        return a.Cena > b.Cena;
    }

    public static Produkt operator ++(Produkt p)
    {
        p.Ilość++;
        return p;
    }

    public static Produkt operator --(Produkt p)
    {
        p.Ilość--;
        return p;
    }
}
