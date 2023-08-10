# Metodit/funktiot


Teknisesti ottaen metodi tarkoittaa nimettyä lauseista koostuvaa joukkoa, eli ohjelman palaa, jota voi kutsua muualta ohjelmakoodista metodille annetun nimen perusteella. Esimerkiksi koodirivillä Console.WriteLine("Hei"); kutsumme Console-luokan staattista WriteLine-metodia.


## Esimerkki:

Alla on koodin pätkä, jossa esitellään c# kielen erilaisia parametreja.
```c#
using System; 

namespace Parametrit 

{ 

    class Parametrit 

    { 

        // void ei palauta mitään, mutta ref muuttuja muuttaa alkuperäistä arvoa! 

        private static void KahdenLuvunNelioRef(ref int arvoParam1) 

        { 

            arvoParam1 = arvoParam1 * arvoParam1; // sama kuin arvoparam1 *=arvoparam1 

        } 

  

        // ei vaikuta alkup arvoon, mutta tyyppi int ja palauttaa arvon, joka voidaan ottaa talteen 

        private static int KolmenLuvunSumma(int param, int param2, int param3) 

        { 

           param3 = Math.Max(param, param2);              // muuttaa param3:n arvoa vain funktion/metodin sisällä, 
                                                          // ei vaikuta kutsuvan koodin arvoon.

           int kolmenLuvunSumma = param + param2 + param3;  // Toimiiko funktio niin kuin on oletettavissa? f(3,3,1) ??

           return kolmenLuvunSumma; 

        } 


        private static void KahdenLuvunNeliö2(int param) 

        { 

            param *= param; 

        } 

        private static void ParametrinToimintaOut(out int number) 

        { 

            number = 44; 

        } 

        // Esitellään parametrien käyttö, value, ref, and out - parametrit  

        static void Main(string[] args) 

        { 

            Console.WriteLine("Olen ohjelma, joka auttaa hahmottamaan aliohjelmia ja parametreja"); 

            // Muuttujat 

            int arvoParam1 = 5; 

            int valueParam2 = 6; 

            int kolmasArvo = 7; 


            //Aliohjelma "normaaleilla"(value) parametreilla 

            //int  

            int summa = KolmenLuvunSumma(arvoParam1, valueParam2, kolmasArvo); 

            Console.WriteLine(summa); 

            Console.WriteLine(arvoParam1); // arvo 5 

            //Console.WriteLine(returnTalteen); // arvo 25 

            KahdenLuvunNeliö2(valueParam2); // arvo 6 

            //aliohjelma ref paramterilla. Ref-param voidaan muokata aliohjelmassa 

            KahdenLuvunNelioRef(ref arvoParam1); 

            Console.WriteLine(arvoParam1); // arvoParanm on nyt 25 

  
            // out parametrin käyttö. Out-param pitää muokata aliohjelmassa ja alustaa, eli antaa  jokin arvo 

            int arvoIlmanAlustusta; 

            ParametrinToimintaOut(out arvoIlmanAlustusta); 

            Console.WriteLine(arvoIlmanAlustusta);     // arvo 44 


            Console.ReadKey(); 

        } 

    } 

}     
```

Teoriaa: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

Helppoja esimerkkejä: https://www.w3schools.com/cs/cs_methods.php

