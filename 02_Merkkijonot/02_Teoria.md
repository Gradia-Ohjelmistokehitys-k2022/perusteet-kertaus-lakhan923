# Merkkijonot

Merkkijonot ovat hieman erilaisia muuttujia kuin esim. kokonaisluvut ja liukuluvut. Merkkijonot ovat olioita, jotka saavat arvokseen tekstiä. Merkkijono (string) koostuu siis merkeistä (char) ja vielä tarkemmin sanottuna merkkijonot ovat char-taulukoita. Taulukot ovat tietorakenteita, joiden kokoa ei voida muuttaa. Pythonissa käytimme listoja, joiden kokoa pystyimme lennosta muuttamaan, mutta c# merkkijonoja emme voi suoraan muuttaa ja siksi niitä kutsutaankin termillä Immutable tai read only.

Alla esimerkkikoodi:
```c#
string merkkijono = "Hello world!";
merkkijono += "We meet again. ";
Console.WriteLine(str);
//tulostaa "Hello World! We meet again."

```
Emme kuitenkaan muuta alkuperäistä merkkijonoa vaan varaamme muistista uuden paikan. 


Tulemme tällä kurssia syventymään olioihin tarkemmin. C# kielessä string oliot ovat ns. immutable eli read only t

## Merkkijonoista tarkemmin

Kyseisestä linkistä löytyy tarkempaa tietoa esim. merkkijonojen metodeista, joista on hyötyä tehtävissä.

https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-5.0

## Merkkijonojen ohjelmoinnista

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

