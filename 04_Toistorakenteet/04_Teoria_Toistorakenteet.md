# Toistorakenteet


## For silmukka
For silmukka toistaa ehdossa mainitun määrän silmukan sisässä olevia lausekkeita.

### Rakenne

	for(alkutila,loppuehto,laskurin kasvatus) // Huom! Ei  puolipistettä lopussa - for lause jatkuu vielä...
	{  
		// toistettavat lausekkeet;
	} // Huom! Ei puolipistettä täälläkään - sulkeutuva aaltosulje kertoo kääntäjälle että yksi lause loppuu ja toinen alkaa, aivan kuten puolipiste

### Esimerkki

	for (int i=0;i<50;i++)
	{  
		// suoritettavat toiminnot;   
		// silmukka suoritetaan 50 kertaa ja saa arvot 0...49
	}

Silmukka voi olla myös vähenevä.

	int i;
	for(i=50;i>0;i--)   // i pienenee yhdellä joka kierroksella

Silmukan laskuri voi myös kasvaa tai pienetä muunkin arvon kuin 1.

	for(int i=0;i<=50;i+=5)	// i kasvaa joka kierroksella viidellä. Ts. i saa arvot 0,5,10,15,20,25,30,35,40,45,50.


For silmukan jälkeen ei tarvitse laittaa aaltosulkuja, jos suoritettavia lauseita on vain yksi. Ts. for suoritaa itseään seuraavaa lausetta toistuvasti.

	for(int i=0;i<10;i++) Console.WriteLine("Numero on " + i);   // puolipiste päättää lauseen ja siis toistuvan koodin


For silmukan lausekkeiden suoritusjärjestys on seuraava. Suluissa suoritusvaihe numerona.

	for(aloitusosa(1);ehto(2);kasvatus(4))
	{
		lauseet(3)
	}

	Lauseet siis suoritetaan ennen kasvatusvaihetta ja alustusosa suoritetaan vain kerran. Muut osat toistuvat joka kierroksella.
	Ohjelman kulku siis on 1,2,3,4,2,3,4,2,3,4...

### Esimerkki:

	Jos for lause on:

	for(i=0;i<2;i++)
	{
		//lauseet
	}

	Lauseet suoritetaan kaksi kertaa ja i saa arvot 0 ja 1.

## Foreach

Foreach toistolauseella käydään taulukoiden ja muiden kokoelmien arvot yksi kerrallaan läpi.
Foreach lauseessa käytetään apumuuttujaa, joka saa yhden taulukon arvon vuorollaan arvoksi. Huomaa, että apumuuttuja on määriteltävä foreach lauseessa.

 
foreach lauseen syntaksi on:

	foreach(tyyppi apumuuttuja in taulukon_nimi)
	{  
		//suoritettavia lauseita
	}
Esim:
	foreach (string sana in sanat) // käydään taulukko sanat läpi. sana muuttuja saa joka kierroksella yhden arvon taulukosta.
	{
		Console.Write(sana+", "); // luettelee taulukon sanat yksi kerrallaan pilkulla eroteltuna
	}
 

Esimerkkiohjelma:

	Console.WriteLine("Anna paloiteltava lause. Anna quit, kun haluat lopettaa.");               
	lause = Console.ReadLine();               
	Console.WriteLine();               

	string[] sanat = lause.Split(); // paloitellaan lause sanoiksi. Split palauttaa taulukon jossa jokainen sana on omalla rivillään. 
	foreach (string sana in sanat) //käydään  taulukko sanat läpi
	{                   
		Console.WriteLine(sana);               
	}               
	Console.WriteLine("\nSanoja oli " + sanat.Length + " kappaletta.\n");

Esimerkkiohjelma 2:

	double [] a={1.6,2.1,4,3};     
	foreach (double apu in a)      
	{      
		//suoritettavat lauseet     
	}

Esimerkkiohjelma 3:

	char [] kirjain={'a','k','s'};    
	foreach (char apukirjain in kirjain)     
	{     
		//suoritettavat lauseet    
	}   
## While

While silmukka toistaa silmukan sisällä olevat lauseet kun silmukan ehto täyttyy.

while (ehto)
{
 lause;
 lause;
}
 
Esimerkki:

	int luku = 0;
	while (luku < 10)
	{
		Console.WriteLine("Luku on " + luku);
		++luku;
	}

	Tämä silmukka vastaa for-silmukkaa
	for(int luku=0;luku<10;luku++)
	{
		Console.WriteLine("Luku on " + luku);
	}

While silmukka on hyödyllinen kun kierrosten lukumäärä ei ole ennalta tiedossa esim. käyttäjän syötteiden käsittelyssä.

While silmukasta on olemassa variantti do-while:

do {
  lause;
} while(ehto);

Erona do-whilessä tavalliseen while lauseeseen on se, että toistettava lause toistetaan ENNEN kuin ehto tarkistetaan, kun taas tavallisessa while lauseessa ehto
tarkistetaan ensin.

Esim:
	// tämä ei tulosta mitään sillä ehto ei toteudu
	while(false)
	{
		Console.WriteLine("1 kierros!");
	}


	// tämä tulostaa yhden kerran "1 kierros!" ennen kuin evaluoi ehdon eikä jatka toiselle kierrokselle
	do
	{
		Console.WriteLine("1 kierros!");
	} while(false);

