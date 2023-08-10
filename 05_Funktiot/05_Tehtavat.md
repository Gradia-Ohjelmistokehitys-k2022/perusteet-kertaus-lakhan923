## Tehtävä 1

Kopioi alla oleva koodi Visual Studioon. Lisää kommentoituihin kohtiin omaa koodiasi niin, että ohjelma toimii. Tarkemmin: kutsu pääohjelmassa Pienin ja Suurin metodeja. Luo koodi joka selvittää kolmesta luvusta suurimman ja pienimmän (älä käytä valmiita Min ja Max metodeja). Palauta pienin sekä suurin arvo ja tulosta ne pääohjelmassa.

```c#
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace funktiot 
{ 
    class Program 
    { 
        private static int Pienin(int eka, int toka, int kolmas) 
        { 
           // oma koodi 
        } 

        private static int Suurin(int eka, int toka, int kolmas) 
        { 
            // oma koodi 
        } 

        static void Main(string[] args) 
        { 
            int luku1,luku2,luku3,suurinLuku,pieninLuku; 
            string syote; 

            Console.WriteLine("Anna eka luku:"); 
            syote = Console.ReadLine(); 
            luku1 = int.Parse(syote); 
            Console.WriteLine("Anna toka luku:"); 
            syote = Console.ReadLine(); 
            luku2 = int.Parse(syote); 
            Console.WriteLine("Anna kolmas luku:"); 
            syote = Console.ReadLine(); 
            luku3 = int.Parse(syote); 

            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3. 

            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 
        } 
    } 
}
```

## Tehtävä 2

Tee ohjelma ja siihen metodi TulostaTeksti. Kysy pääohjelmassa teksti, joka lähetetään TulostaTeksti-metodille tulostettavaksi.

## Tehtävä 3

Tee ohjelma, joka kysyy käyttäjältä 5 lukua ja lisää ne listaan. Tee ohjelmaan metodit KeskiArvo(List<double> lista) ja Mediaani(List<double> lista).  KeskiArvo() metodi laskee ja palauttaa listan keskiarvon ja Mediaani palauttaa järjestetyn listan keskimmäisen arvon. Tietoa mediaanista: https://fi.wikipedia.org/wiki/Mediaani



