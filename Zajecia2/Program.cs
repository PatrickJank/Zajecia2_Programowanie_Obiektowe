namespace Zajecia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();
            //names.Add("Ania");
            //names.Add("Hania");
            //names.Add("Frania");
            //names.Add("Maria");
            //if (ZapisOdczyt.Save(names, "data.txt") == true)
            //    Console.WriteLine("DATA SAVED");
            //if (ZapisOdczyt.Load("data.txt", out names) == true)
            //{
            //    foreach (string name in names)
            //        Console.WriteLine(name);

            //}
            //else
            //    Console.WriteLine("Błąd odczytu");

            List<DaneOsoba> myCollection = new List<DaneOsoba>();

            var os1 = new DaneOsoba()
            {
                Imie = "Patryk",
                Nazwisko = "Jankiewicz",
                Wiek = 25
            };
            myCollection.Add(os1);

            var os2 = new DaneOsoba()
            {
                Imie = "Gal",
                Nazwisko = "Anonim",
                Wiek = 26
            };
            myCollection.Add(os2);

            var os3 = new DaneOsoba()
            {
                Imie = "Tomek",
                Nazwisko = "Świnka",
                Wiek = 4
            };
            myCollection.Add(os3);

            ZapisOdczyt.Save(myCollection, "data2.txt");



        }
    }
}