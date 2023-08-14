using system;

class Merkkijonot_Task_1
{
    public static void main()
    {

        string myStr = "Virtanen";
        Console.WriteLine(myStr);
      
        string str = "Virtanen";
        String modified = str.Insert(1, " ");
        Console.WriteLine(modified);

        string name = "Virtanen";
        char[] cArray = name.ToCharArray();
        Array.Reverse(cArray);  
        string resultString = String.Join(" ", cArray);
        Console.WriteLine(resultString );   
    }
}

class Merkkijonot_Task_2
{
    public static void main()
    {
        string henkilo = "Virtanen";
        int a_Paikka = henkilo.IndexOf('a'); // search for letter "a"
        Console.WriteLine(a_Paikka); // 4
        
        int eioo = henkilo.IndexOf('A'); // search for letter "A"
        Console.WriteLine(eioo); // -1
    }
}

class Merkkijonot_Task_3
{
    public static void main()
    {

    }
}
