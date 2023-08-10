# Taulukot ja listat

# Taulukot

Taulukot voivat olla joko yksi- tai moniulotteisia ja koostua minkä tahansa perustietotyypin elementeistä (esim. int, double, string, char).

Yksiulotteinen taulukko

	Taulukon tunnistaa hakasulkeista tyypin perässä:
	tyyppi [] taulukon_nimi
	Esim.
		string[] taulukollinen_merkkijonoja;

	"new" operaattorilla varataan taulukolle muistitila. Uusi taulukko luodaan näin: 
		tyyppi[] taulukon_nimi = new tyyppi[taulukon_koko]
	Esim.
		int[] arvosanat = new int[20]; // arvosanat on nyt taulukko jossa on 20 numeroa

	tai jos taulukko on esitelty erikseen:
		string[] lista_merkkijonoja;
		lista_merkkijonoja = new string[50]; // merkkijonotaulukossa on nyt tilaa 50:lle stringille 
              

Taulukot voi myös alustaa esittelyn yhteydessä seuraavasti: 

	int [] arvosanat = {1,2,3,4,5};   // C# varaa automaattisesti oikean muistimäärän

	string [] nimet = new string[3];   // alustetaan yksitellen
	nimet[0] = ”Matti”;
	nimet[1] = ”Kalle”;
	nimet[2] = ”Ville”;

	string[] nimet = { "Matti", "Kalle" , "Ville" };  // alustetaan kerralla

	char [] vokaali = {'a','e','i','o','u','y','ä,'ö'};   //C# varaa automaattisesti oikean muistimäärän

Taulukoiden indeksinumerot

	Huomaa, että taulukko alkaa aina alkiosta nolla, eli ”int [3] arvosanat” määrittely varaa taulukon paikat: arvosanat[0]; arvosanat[1]; arvosanat[2];
	Jos tässä taulukossa yrittää käsitellä elementtiä arvosanat[3], eli käsitellä neljättä elementtiä jota ei ole olemassa, saa aikaan virhekeskeytyksen
	IndexOutOfRangeException.


Taulukon tulostaminen 

	Taulukon yksittäiseen alkioon viitataan indeksi numerolla. Eli nimet taulun tulostus hoituisi seuraavasti.
		Console.WriteLine(nimet[0]);
		Console.WriteLine(nimet[1]);
		Console.WriteLine(nimet[2]);

		...tulostaa...

		Matti
		Kalle
		Ville


Kaksi- ja useampiulotteiset taulukot

	Kaksiulotteista taulukkoa voi verrata koordinaatistoon, jossa on korkeus ja leveys. Kolmiulotteisessa on vielä syvyys.

	Esim: kaksiulotteiset taulukot
```c#
		int[,] kertotaulu = new int[10, 10];	// kaksiulotteinen taulukko 10 kertaa 10 alkiota. 
		for(int i = 0; i < 10; i++)
		  for(int j = 0; j < 10; j++)
		    kertotaulu[i, j] = i * j;
		
		// tämäkin on kaksiulotteinen taulukko
		double[,] koordinaattipiste = new double[100, 3];  // 100 kpl kolmen alkion (x, y, z) 'rivejä'.
		koordinaattipitse[99][0] = x;
		koordinaattipitse[99][1] = y;
		koordinaattipitse[99][2] = z;
```		

	Esim: kolmiulotteinen taulukko
```c#	
		// tässsä kolmiulotteinen taulukko (2 vastausta, 2 kieltä, 3 eri sanaa)
		string[,,] vastaus =
                   {
                     { // eit kahdella eri kielellä kolmella eri tavalla
                       {"ei", "juu ei", "ei tasan"}, {"no", "nope", "no way"}
                     },
                     { // joot kahdella eri kielellä kolmella eri tavalla
                       {"kyllä", "joo", "juu"}, {"yes", "sure", "yeah"}
                     }
                  };
            Console.WriteLine(vastaus[0, 1, 0]); // ei-sana, englanniksi, eka vaihtoehto
            Console.WriteLine(vastaus[1, 0, 2]); // kyllä-sana, suomeksi, viimeinen vaihtoehto
```
 

	Yksi ja kaksiulotteisia taulukoita käytetään eniten, mutta talukoissa voi olla miljardeja ulottuvuuksia. Tälläisten taulukoiden hahmottaminen on vaikeaa
	ja niitä käytetään lähinnä tietyissä koneoppimisalgoritmeissa kuten esimerkiksi asioita automaattisesti kategorisoivissa tekoälyissä.


Esimerkkiohjelma yksi- ja moniulotteisesta taulukosta:

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arvosanat
{   
	class Program   
	{       
		static void Main(string[] args)       
		{           
			int i, j, x;           
			Console.Write("Kuinka monta oppilasta kurssilla oli? ");

			try           
			{               
				x = int.Parse(Console.ReadLine());
				//tässä x kuvaa oppilaiden lukumäärää, joka kysytään käyttäjältä

				string[] nimet = new string[x];               
				int[,] arvosanat = new int[x, 3];               

				//Kysytään oppilaan nimi ja arvosanat               
				for (i = 0; i < x; i++)
				{                   
					Console.Write("Anna oppilaan nimi: ");                  
					nimet[i] = Console.ReadLine();
					for (j = 0; j < 3; j++)
					{                       
						Console.Write("Anna kurssin " + (j + 1) + " arvosana: ");                        
						arvosanat[i, j] = int.Parse(Console.ReadLine());
					}
				}
				//Tulostetaan tiedot
				for (i = 0; i < x; i++)
				{
					Console.Write("\nOppilaan " + nimet[i] + " arvosanat:");                    
					for (j = 0; j < 3; j++)
						Console.Write("\t" + arvosanat[i,j]);
				}
			}
			catch
			{               
				Console.WriteLine("Virheellinen syöte");
			}

			Console.WriteLine("\n\nPaina jotain näppäintä jatkaaksesi...");
			Console.ReadKey(true);
		}
	}
}
```
## Listat

Taulukoiden lisäksi hyvin tyypillinen ja hyödyllinen tietorakenne on lista. Lista on helppokäyttöisempi kuin taulukko (array) sillä lista kasvaa automaattisesti.

Tarkastellaan taulukkoa jonne tallennetaan oppilaiden nimiä:
	string[] nimet=new string[10];
	int ensimmainen_vapaa_indeksi=0;

	// lisää oppilas
	nimet[ensimmainen_vapaa_indeksi++]="Leo"; // lisää taulukon ensimmäiseen vapaaseen paikkaan nimen Leo, ja kasvattaa vapaan paikan indeksiä 

Mitä tapahtuu kun taulukkoon on tallennettu 10 nimeä? Seuraava oppilaan lisääminen saa taulukon vuotamaan yli ja ohjelma kaatuu.

Ohjelmoija voi varautua tälläiseen tilanteeseen luomalla tässä tilanteessa uusi suurempi taulukko ja kopioimalla jokaisen nimen siihen. Tämä on kuitenkin
työlästä niin ohjelmoijan kuin tietokoneen kannalta.

List toimii kuin taulukko mutta sillä on seuraavat käyttöä helpottavat ominaisuudet:

	Lista kasvaa automaattisesti ja vain tarvittaessa.
	Lista voi tallentaa null-arvoja sekä duplikaatteja (useampia kappaleita samasta datatyypistä).
	Listat tukevat indekseriä (indexer) jonka takia foreach tukee niitä.
	Listaan voi lisätä elementtejä (jäseniä) Add metodilla.
	Listaan voi viitata IList<T> tai List<T> tyyppisellä muuttujalla. List<T> on näistä monikäyttöisempi ja tarjoaa useita apufunktioita.
	LINQ kirjasto tarjoaa vielä enemmän apufunktioita listojen käsittelyyn, muunmuassa hakufunktioita joiden avulla listasta voi etsiä. 

Lista esitellään seuraavasti:
```c#
	List<tyyppi> listannimi = new List<tyyppi>();

	Esimerkiksi taulukon
		 string[] nimet=new string[10];
	sijaan voitaisiin käyttää listaa
		List<string> nimet=new List<string>();
	tähän voi lisätä jäseniä kätevästi Add metodilla:
		nimet.Add("Leo");
```

Lopuksi,
Aivan kuten taulukko, lista voi olla moniulotteinen - tosin syntaksi on hieman sekava:
	List< List< string > > lista_string_listoista = new List< List< string > >();

Lisää listasta voit lukea (englanniksi) https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2



