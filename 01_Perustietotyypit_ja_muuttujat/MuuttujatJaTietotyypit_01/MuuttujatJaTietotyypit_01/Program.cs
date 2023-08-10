
/*
 * Value types (derived from System.ValueType, e.g. int, bool, char, enum and any struct) can be allocated on the heap or on the stack, depending on where they were declared.
    If the value type was declared as a variable inside a method then it's stored on the stack.
    If the value type was declared as a method parameter then it's stored on the stack.
    If the value type was declared as a member of a class then it's stored on the heap, along with its parent.
    If the value type was declared as a member of a struct then it's stored wherever that struct is stored.
 */

//int ika = 5;
//int ika2 = 10;
//Console.WriteLine("Ika on: {0}", ika + ika2);

//int yhteensa = ika + ika2;

//eka ratkaisu
//string elain = "Kissa";
//char[] elainArray = elain.ToCharArray();

//string kaannettyElain = String.Join(" ", elainArray);

//Console.WriteLine(kaannettyElain);

using System.Diagnostics;

string syote = "k issa";

var sw = new Stopwatch();
//Tulostus(syote);
//Tulostus2(syote);
VaihdaRiviaKunTyhja(syote);
//SananIndeksi(syote);
//KaannaSana(syote);
KaannaSana(syote);


if(syote == "5" || syote == "6")
{
    Console.WriteLine(syote);
}

/// <summary>
/// 
/// </summary>
void KaannaSana(string syote)
{
    throw new NotImplementedException();
}

Metodi3(syote);


/// <summary>
/// Metodi3
/// </summary>

void Metodi3(string syote)
{
    throw new NotImplementedException();
}

/// <summary>
/// 
/// </summary>
void SananIndeksi(string syote)
{
    throw new NotImplementedException();
}

void VaihdaRiviaKunTyhja(string syote)
{

    foreach (char c in syote)
    {
        if(c == ' ')
        {
            Console.WriteLine();
        }
        Console.Write(c);
    }

}

//Reverse(syote);

// Toinen tapa
static void TyhjaMerkkiJokaValiin(string syote)

{
    char[] merkkiJono = syote.ToCharArray();

    foreach (char merkki in merkkiJono)
    {
        Console.Write(merkki + " ");
    }
    Console.WriteLine();
}


// kolmas tapa

static void Tulostus2(string syote)
{

    ////foreach
    //foreach  (char c in syote)
    //{
    //    Console.Write(c + " ");
    //}

    //Console.WriteLine();

    //for
    var sw = new Stopwatch();
    for (int i = 0; i < syote.Length; i++)
    {
        Console.Write(syote[i] + " ");
    }
    Console.WriteLine();

    sw.Stop();
    var timeSpent = sw.ElapsedMilliseconds;
    Console.WriteLine(timeSpent);

}


int syote3 = Convert.ToInt32(Console.ReadLine());
int[] taulukko = new int[syote3];

for (int i = 0; i < taulukko.Length; i++)
{

}


Console.WriteLine("Kuinka monta lukua");





static void Reverse(string syote)
{
    for (int i = syote.Length - 1; i >= 0; i--)
    {
        Console.Write(syote[i] + " ");
    }
}