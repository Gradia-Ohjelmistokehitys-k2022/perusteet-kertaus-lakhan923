// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string syote = "Kissa";
Console.WriteLine(syote);
string syote2 = "Keijo";
syote = "Keijo";
Console.WriteLine(syote);
Console.WriteLine(syote == syote2);
Console.WriteLine(syote.Equals(syote2));

string arvo1 = "Kissa";
string arvo2 = "Kissa";

if(arvo1 == arvo2)
{
    Console.WriteLine("Nää on samoja");
}

else if (arvo1 == arvo2 && arvo2 == "Merkki")
{
    Console.WriteLine("Jotain");
}

else if (arvo1 == "Merkki" && arvo2 == arvo1) {

}
