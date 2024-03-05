public class Programm
{
    public static void Main(string[] args)
    {
        Magazyn magazyn = new Magazyn("Magazyn 1");

        bool kontynuuj = true;
        while (kontynuuj)
        {
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Dodaj produkt");
            Console.WriteLine("2. Wyświetl produkty");
            Console.WriteLine("3. Sortuj produkty");
            Console.WriteLine("4. Zakończ");
            Console.Write("Wybór: ");

            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    DodajProdukt(magazyn);
                    break;
                case "2":
                    magazyn.WyświetlProdukty();
                    break;
                case "3":
                    magazyn.SortujProdukty();
                    break;
                case "4":
                    kontynuuj = false;
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static void DodajProdukt(Magazyn magazyn)
    {
        Console.Write("Nazwa produktu: ");
        string nazwa = Console.ReadLine();
        Console.Write("Cena produktu: ");
        decimal cena = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ilość produktu: ");
        int ilość = Convert.ToInt32(Console.ReadLine());

        magazyn.DodajProdukt(new Produkt(nazwa, cena, ilość));
        Console.WriteLine("Produkt dodany.");
    }
}
