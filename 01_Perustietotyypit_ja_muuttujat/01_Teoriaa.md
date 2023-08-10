# Muuttujat ja konsolin käyttö

## Muuttujat

Muuttujat ovat nimettyjä tiedon säilytyspaikkoja. Muuttujalle pitää siis antaa nimi sekä sen tiedon tyyppi mitä siihen sijoitetaan. Muuttujien esittelyn muoto on 

[tyyppi] [nimi];

int luku;

string teksti;

bool tosi;

Samaa tyyppiä olevia muuttujia voi esitellä useita peräkkäin: 

int ekaluku, lukuKaksi, luku3;


Muuttujille voi antaa alkuarvot:

string teksti = "Tässäpä tekstiä";

int ekaluku = 51, lukuKaksi = 621, luku3 = 25;


Muuttujaan sijoitetaan arvo: 

int summa;

summa = 1 + 2;

## Laskuoperaatiot

Muuttujilla on samanlainen rooli ohjelmoinnissa kuin matematiikassa, ja niillä voidaan tehdä erilaisia laskutoimituksia (yhteen, vähennys, kerto, jako jne). Numeromuuttujien lisäksi ohjelmoinnissa voi kuitenkin olla myös esimerkiksi merkkimuuttujia. Muuttujista on runsaasti erilasia tyyppejä, jotka kertovat esimerkiksi onko muuttuja numero- vai merkkimuuttuja.
Huomaathan, että C Sharp käyttää englanninkielistä merkistöä, eli muuttujien, ja metodien (käskyjen) nimissä ei voi olla ”ääkkösiä” (ä,ö,å).

Kaikki muuttujat on esiteltävä ennen käyttöä.
//Muuttuja määritellään seuraavilla tavoilla:
int a;
int x,y,z;
long k;

Kuten huomasit, samantyyppisiä muuttujia voi esitellä peräkkäin lueteltuna pilkulla erotettuna. Usein muuttujat joutuu myös alustamaan. Jos yrität käyttää muuttujaa ohjelmassa ilman, että siihen on varmasti sijoitettu arvo, kääntäjä ilmoittaa virheestä: Use of unassigned local variable 'a'. Tässä tapauksessa muuttuja a oli jätetty alustamatta.

//Muuttujat voi esittelyn yhteydessä alusta näin
int a=0;
int x=8, y=0, z;
long k=0;

//Tässä z on jätetty alustamatta

## Aritmeettiset operaattorit

```code
Operaattori       Tarkoitus                 Esimerkki

+                 Summa (yhteenlasku)       a+b
-                 Erotus (vähennyslasku)    a-b
*                 Tulo (kertolasku)         a*b
/                 Osamäärä (jakolasku)      a/b
%                 Jakojäännös               a%b
```

## Tiedon lukeminen ja kirjoittaminen konsolin avulla

### Tiedon lukeminen 

Console.ReadLine(); 

Console.WriteLine();

Tiedot luetaan konsoliohjelmissa Console.ReadLine() metodilla. **Tieto luetaan string tyyppisenä, joten se on muutettava numeeriseksi erillisellä Parse metodilla, mikäli halutaan käsitellä numeroa**.

#### Esimerkiksi:

string syote = Console.ReadLine(); 

int luku = int.Parse(syote);

C Sharpissa Console.ReadLine() metodilla ei voi kysymykseen laittaa tekstiä, vaan itse kysymys on kirjoitettava Console.WriteLine() metodilla. Tyyppimuutoksen voi tehdä myös suoraan kysymyslauseessa.

Console.WriteLine(”Anna luku: ”);                   

luku = int.Parse(Console.ReadLine());

Jos nyt kuitenkin syötetään vastauksesi kirjain, tapahtuu virhe, kun yritetään muuttaa kirjainta numeroksi (int tyypiseksi):

int.Parse(string s) toiminta:

• Integer in RANGE > returns integer value

• Null value > ArguementNullException

• Not in format > FormatException

• Value not in RANGE > OverflowException


Convert.ToInt32(string s) toiminta:

• Integer in RANGE > returns integer value

• Null value > returns "0"

• Not in format > FormatException

• Value not in RANGE > OverflowException


### Tulostaminen

Konsoliohjelmissa tieto tosiaan tulostetaan Console.WriteLine() metodilla: Console.WriteLine(”Tulostettava teksti”);        

Lauseita voi yhdistellä ja muuttujia lisätä + operaattorin avulla. 

#### Esimerkiksi:  

Console.WriteLine(”Muuttujan a arvo on” + a + ”ja muuttujan b arvo on” + b); 

Jos et halua rivinvaihtoa lauseen jälkeen, voit käyttää myös Console.Write() metodia: Console.Write(”Tulostettava teksti.”); 

Muuttujat voi tulostaa myös seuraavasti:  Muuttujat voi laittaa aaltosulkeissa tulostuslauseen sekaan. Huomaa, että aaltosulkeisiin laitetaan numero. Lauseeseen sijoitettavat muuttujat listataan pilkulla erotettuna heittomerkkien jälkeen. Luettelon ensimmäisen muuttujan numero on 0, seuraavan 1 jne. 

#### Esimerkiksi:  

int x=20, y=40;  

Console.WriteLine("X-koordinantti on {0} ja Y-koordinantti on {1}.", x,y); //Lause tulostaa saman kuin:

Console.WriteLine("X-koordinantti on " + x + " ja Y-koordinantti on " + y + ".");  



