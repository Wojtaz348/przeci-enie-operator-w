using Zadanie1;

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
            produkt.WyświetlInformacje();
        }
    }

    public void SortujProdukty()
    {
        Produkty.Sort(); 
    }
}


