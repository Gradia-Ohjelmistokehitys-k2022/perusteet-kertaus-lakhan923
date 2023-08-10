# Ohjelmoinnin-perusteet-kertaus-kevät-2022
Repositorio Gradian Ohjelmoinnin perusteet ja versionhallinta kurssille. 

Työkaluna toimii visual studio community 2022, jonka saa ladattua osoitteesta https://visualstudio.microsoft.com/vs/
Asennuksen yhteydessä asennetaan .NET desktop development. Target framework NET 6.0.

Versionhallinta https://github.com/. Jos sinulla ei ole git-asennusta, niin se löytyy osoitteesta https://git-scm.com/download/win

Ohjelmistotuotannon discord https://discord.gg/Qp2JQSqva3


# Git ohje

# Repositorion kloonaaminen omalle koneelle
Tämä tehdään vain kerran kurssin aluksi. Jokainen kurssilainen saa linkin tehtäviin githubin luomisen jälkeen.

1. Avaa GitBash hakemistoon jonka alle haluat tehtäväkansion. Tämä onnistuu klikkaamalla oikealla hiirennapilla hakemistoa Windows Explorerissa ja valitsemalla "Avaa GitBash tässä."
2. kirjoita komento ```git clone "oma repository" ```. Url:n saa githubista Code-nappia painamalla.

# SSH avaimen luonti Githubia varten
Perjantaina 13. elokuuta Github muutti kirjautumisvaatimuksiaan ja login/salasana kirjautuminen ei enää toimi. Tämän takia luomme kaikille SSH avaimet ja käytämme niitä autentikointiin Githubin kanssa.
**HUOM! Jos pääset normaalisti kirjautumaan Githubiin ei SSH avaimiin siirtyminen ole pakollista. Tee siis nämä vaiheet vain jos Github ei enää päästä sinua sisään!**

1. Avaa GitBash ```olio-ohjelmointi-2022-kevat``` hakemistossa.
2. Kokeile komentoa ```ssh -T git@github.com```. Mikäli komennon vastauksesta löytyy kohta ```...You've successfully authenticated...``` olet valmis eikä tätä ohjetta tarvitse seurata pidemmälle. Mikäli autentikointi taas epäonnistuu jatka kohtaan 3.
3. ```ls ~/.ssh``` - Mikäli komento onnistuu ja tulostaa hakemiston josta löytyy tiedostot ```id_rsa``` ja ```id_rsa.pub``` hyppää kohtaan 5. Mikäli tiedostot puuttuvat tai koko ```.ssh``` hakemisto puuttuu siirry kohtaan 4.
4. ```ssh-keygen -t rsa -b 2048``` - Vastaa jokaiseen kysymykseen painamalla enteriä (älä siis muuta oletusvastauksia.)
5. ```ls ~/.ssh``` - Nyt komennon pitäisi tulostaa hakemisto josta löytyy tiedostot ```id_rsa``` ja ```id_rsa.pub```.
6. ```cat ~/.ssh/id_rsa.pub``` - Tulostaa konsoliin julkisen avaimesi. Kopioi avain talteen. Esimerkki avaimesta alla.
7. Mene githubin avaintenhallintasivulle ```https://github.com/settings/keys```
8. Klikkaa vihreää "New SSH key" painiketta.
9. Keksi avaimelle nimi "Title" kenttään.
10. Liitä kohdassa 6 kopioimasi avain "Key" kenttään.
11. Klikkaa vihreää "Add SSH key" painiketta.
12. Kokeile GitBashissa että yhteys toimii nyt: ```ssh -T git@github.com```. Mikäli komennon vastauksesta nyt löytyy kohta ```...You've successfully authenticated...``` siirry kohtaan 13. Muussa tapauksessa ota yhteyttä opettajaan. Jos ssh valittaa ettei tunne githubin palvelinta ja kysyy haluatko varmasti lisätä tämän palvelimen tunnettujen palvelimien listalle, vastaa ```yes``` (kirjoita sana yes kokonaan).

*Esimerkki kohdan 6. ja 10. avaimesta:*
# Uusien tehtävänantojen hakeminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet main haarassa (branch), ja että sinulla ei ole avoimia muutoksia (jotka näkyvät punaisena tai vihreänä). Mikäli niitä on, tallenna ne ensin komennoilla ```git add .```, ```git commit -m "Muutokset talteen."```.
2. <mark>Tämä tehdään vain kerran.</mark> Lisätään alkuperäinen pohja haettavaksi seuraavalla komennolla, jos muutoksia materiaaleihin tulee.```git remote add upstream https://github.com/Gradia-Ohjelmistokehitys-k2022/ohjelmointi-kertaus-pohja```
3. Haetaan uusin versio upstreamista ``git pull upstream main --allow-unrelated-histories`` --allow-unrelated-histories voi ratkaista githubclassroomiin liittyviä ongelmia.
4. Jos merge conflicteja tulee, niin ne ratkotaan :) Esim. visual studio 2022 on helppo työkalu confliktien ratkomiselle.

# Oman työn palauttaminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet omassa haarassa (branch), ja että sinulla ON avoimia muutoksia (jotka näkyvät punaisena).
2. ```git add .```
3. ```git status``` - tarkista että muutokset näkyvät nyt vihreinä.
4. ```git commit -m "Tehtävän <se ja se> palautus."``` - laita palauttamasi tehtävän nimi ja/tai numero kommenttiin.
5. ```git push``` 

# Muita hyödyllisä komentoja GitBashissä

## ```cd```
Siirtyy toiseen hakemistoon, esim. ```cd 00_Hevonen``` siirtyy hakemistoon ```00_Hevonen```

## ```ls```
Listaa nykyisen hakemiston sisällön, eli tässä hakemistossa olevat tiedostot ja hakemistot.

## ```git status```
Kertoo missä haarassa (branch) olet, ja mitä tiedostoja olet muokannut, mitkä on merkitty (staged) lisättäväksi repositorioon. Lisäksi komento kertoo onko oma kopiosi haarasta samalla tasolla kuin GitHub palvelimella oleva, vai onko sinulla paikallisia muutoksia joita et ole vielä työntänyt (push) palvelimelle.

## ```git log```
Listaa nykyisen haarasi (branchin) viimeisimmän version, sekä kaikki sitä suoraan edeltävät versiot.

## ```git log --graph --all --decorate```
Piirtää konsoliin graafin koko repositorion sisällöstä. Kaikkien haarojen kaikki versiot yhtenä (isona) tekstigrafiikkakuvana.
