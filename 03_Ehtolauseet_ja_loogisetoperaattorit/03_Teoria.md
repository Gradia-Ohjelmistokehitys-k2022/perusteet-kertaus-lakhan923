# Ehtolauseet ja loogiset operaatiot

## If-lause

Ehtolauseet ovat ohjelmoinnin perusrakenne, jolla tarkastellaan erilaisten tilanteiden lopputulemaa ja voidaan näin ollen ohjata ohjelman toimintaa.

```c#

if (ehto)                                  //huom. Ei puolipistettä lopussa
{
     //suoritetaan, jos ehto on tosi
}
else if (ehto2)                      //huom. Ei puolipistettä lopussa
{
     //suoritetaan, jos ehto2 on tosi
}
else                                       //huom. Ei puolipistettä lopussa
{
     //suoritetaan, jos ehto oli epätosi
}

”else if” eikä ”else” osiot eivät ole pakollisia. Niillä kuitenkin saadaan monipuolisempia valintoja ohjelmaan. Ehto lauseen jälkeen ohjelman suoritus jatkuu normaalisti seuraavalta riviltä.

Esimerkiksi:

if (x < 10)
{
    //suoritetaan, jos x < 10
}
else if (x<12)
{
    //suoritetaan, jos x > 9 mutta pienempi kuin 12

}
else if (x == 12)
{
    //suoritetaan, jos x = 12
}
else
{
    //suoritetaan, jos mikään aiemmista tapauksista ei toteudu
}
 
```

### Tarkempaa tietoa ja malleja

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements

https://www.w3schools.com/cs/cs_conditions.php

## Loogiset operaattorit

C#:ssa on boolean tyyppinen muuttuja, joka sisältää joko arvon ”true” (tosi) tai ”false” (epätosi). Boolean-operaattorilla suoritetaan laskutoimitus, jonka tulos on joko ”true” tai ”false”.

```code
Vertailuoperaattorit:
	Operaattori	Kuvaus			Esimerkki		          Tulos,jos luku on 8
	!		Ei	         	!(luku==8)		             	false
	AND tai &&	Ja	        	(luku > 8) && (luku < 12)	     	false
	OR tai ||	Tai	     		(luku > 12) || (luku < 9)       	true

Erilaisia operaatioita
	Operator category			Operators
	Primary					x.y
	Unary					+x
	Multiplicative				x * y
	Additive			        x + y
	Shift					x << y
	Relational and type testing             x < y
	Equality				x == y
	Logical AND				x & y
	Logical XOR				x ^ y
	Logical OR				x | y
	Conditional AND		                x && y
	Conditional OR				x || y
	Null-coalescing		                x ?? y
	Conditional				?:
	Assignment and lambda expression	x = y
```

### Teoriaa

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators

Helloja esimerkkejä https://www.w3schools.com/go/go_logical_operators.php

