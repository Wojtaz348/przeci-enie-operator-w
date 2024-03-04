namespace Zadanie1;
using System;
using System.Collections.Generic;

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

    public void WyświetlInformacje()
    {
        Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}");
    }

  
}

class Program
{
    static void Main(string[] args)
    {
       
        Produkt produkt1 = new Produkt("Zegarek",1333 , 70);
        Produkt produkt2 = new Produkt("Fifa",100, 40);
        Produkt produkt3 = new Produkt("Telefon", 3500, 8);

        
        produkt1.WyświetlInformacje();
        produkt2.WyświetlInformacje();
        produkt3.WyświetlInformacje();

        

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
