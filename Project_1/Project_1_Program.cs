// See https://aka.ms/new-console-template for more information

/// <summary>
/// Tämä projecti sisältää neljä tehtävää!
/// </summary>


// Tämä on Tehtävä yksi.
System.Console.WriteLine("Hei mailmaa");

int ikä;
string nimi;

System.Console.WriteLine("Mikä sun nimi on?");
nimi = Console.ReadLine();

System.Console.WriteLine("Minkä ikäinen sinä olet?");
ikä = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Hey " + nimi + "," + ikä + "!");
Console.ReadLine();

// Tämä on Tehtävä kaksi.

double a;
double b;
double Tulos;

System.Console.WriteLine("Syöttö ensimmäinen numero: ");
a = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Syöttö toinen numero: ");
b = Convert.ToDouble(Console.ReadLine());

Tulos = a + b;

System.Console.WriteLine("{0} + {1} = {2}", a, b, Tulos);
Console.WriteLine("Press any key to exit");

//Tämä on Tehtävä kolme.

Console.WriteLine("Syöttö numero: ");
int j = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)

{
        Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
        Console.ReadLine();
}


// Tämä on Tehtävä neljä.

double euros;
double dollars;
double pounds;
double Currentvalue;

Console.Write("Input number in euros: ");
euros = Convert.ToInt32(Console.ReadLine());

Currentvalue = 1.09;
dollars = euros * Currentvalue;
Console.WriteLine("{0} euros  = {1} dollars", euros, dollars);

Currentvalue = 0.85;
pounds = euros * Currentvalue;
Console.WriteLine("{0} euros = {1} pounds", euros, pounds);

