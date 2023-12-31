using System;
					
class KlasaC
{
    public int Zbroj(int[] niz)
    {
        int zbroj = 0;
        foreach (int broj in niz)
        {
            zbroj += broj;
        }
        return zbroj;
    }

    public double Prosjek(int[] niz)
    {
        int zbroj = Zbroj(niz);
        double prosjek = (double)zbroj / niz.Length;
        return prosjek;
    }
}

class Program
{
    static void Main(string[] args)
    {
        KlasaC objekt = new KlasaC();
        int[] brojevi = new int[5];

        Console.WriteLine("Unesite 5 cijelih brojeva:");
        for (int i = 0; i < brojevi.Length; i++)
        {
            brojevi[i] = Convert.ToInt32(Console.ReadLine());
        }

        int zbroj = objekt.Zbroj(brojevi);
        double prosjek = objekt.Prosjek(brojevi);

        Console.WriteLine("Zbroj: " + zbroj);
        Console.WriteLine("Prosjek: " + prosjek);

        Console.ReadLine();
    }
}
	