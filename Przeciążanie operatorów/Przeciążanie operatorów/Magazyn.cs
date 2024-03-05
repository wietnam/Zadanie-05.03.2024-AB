public class Magazyn
{
    public string Nazwa { get; set; }
    public List<Produkt> Produkty { get; set; }

    public Magazyn(string nazwa)
    {
        Nazwa = nazwa;
        Produkty = new List<Produkt>();
    }

    public void DodajProdukt(Produkt produkt)
    {
        Produkty.Add(produkt);
    }

    public void WyświetlProdukty()
    {
        foreach (var produkt in Produkty)
        {
            Console.WriteLine(produkt);
        }
    }

    public void SortujProdukty()
    {
        Produkty.Sort((x, y) => x.Cena.CompareTo(y.Cena));
    }
}
