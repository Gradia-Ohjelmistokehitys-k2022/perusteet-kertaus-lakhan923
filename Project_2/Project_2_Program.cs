// See https://aka.ms/new-console-template for more information

/// <summary>
/// Tämä projecti sisältää kolme tehtävää!
/// </summary>

// Ensimmäinen tehtävää!

string name;
Console.Write("Input: ");
name = Console.ReadLine();


Console.Write("\n\n");
string myStr = "Virtanen";
Console.WriteLine(myStr);
Console.Write("\n\n");

string nameSpace = "Virtanen";
char[] result = nameSpace.ToCharArray();
for (int i = 0; i < result.Length; i++)
{

        Console.Write(result[i]);
        System.Console.Write(" ");

}
Console.Write("\n\n");

string Reversename = "Virtanen";
char[] reverse = Reversename.ToCharArray();
for (int i = reverse.Length - 1; i >= 0; i--)
{

        Console.Write(reverse[i]);
        System.Console.Write(" ");

}

//----------------------------------------------------------------------------------------------------------------------


// Toinen tehtävää!

string henkilo = "Virtanen";
int a_Paikka = henkilo.IndexOf('a'); // search for letter "a"
Console.WriteLine(a_Paikka); // 4

int eioo = henkilo.IndexOf('A'); // search for letter "A"
Console.WriteLine(eioo); // -1

//----------------------------------------------------------------------------------------------------------------------
// Kolmas tehtävää!

public static void Main()
{
        string name;
        System.Console.WriteLine("Input: ");
        name = Console.ReadLine();
        SplitAndPrintWithSpaces(name);
}

public static void SplitAndPrintWithSpaces(string x)
{

        Console.Write("\n\n");
        string[] result_Array = x.Split(' ');

        foreach (var i in result_Array)
        {
                System.Console.WriteLine(i);
                Console.Write("\n\n");
        }


        foreach (string i in result_Array)
        {
                char[] result = i.ToCharArray();

                for (int j = 0; j < result.Length; j++)
                {
                        Console.Write(result[j]);
                        System.Console.Write(" ");
                }
                Console.WriteLine(" ");
                Console.Write("\n\n");

        }



        foreach (string i in result_Array)
        {
                char[] result = i.ToCharArray();

                for (int j = result.Length - 1; j >= 0; j--)
                {
                        Console.Write(result[j]);
                        System.Console.Write(" ");
                }
                Console.WriteLine(" ");
                Console.Write("\n\n");

        }
 //---------------------------------------------------------------------------------------------------------------------

}