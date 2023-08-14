using system;

class Task_1
{
     static void Main()
     {
        //System.Console.WriteLine("Hei mailmaa");

        System.Console.WriteLine("Hei mailmaa");

        int ikä;
        string nimi;

        System.Console.WriteLine("Mikä sun nimi on?");
        nimi = Console.ReadLine();

        System.Console.WriteLine("Minkä ikäinen sinä olet?");
        ikä = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Hey " + nimi + "," + ikä +"!");
        Console.ReadLine();
        
     } 

     public static void Main()
     {
         double a;
         double b;
         double Tulos;
         
         System.Console.WriteLine("Syöttö ensimmäinen numero: ");
         a = Convert.ToDouble(Console.ReadLine());

         System.Console.WriteLine("Syöttö toinen numero: ");
         b = Convert.ToDouble(Console.ReadLine());
         
         Tulos = a + b;

         System.Console.WriteLine( "{0} + {1} = {2}",a,b,Tulos);
         Console.WriteLine("Press any key to exit");
     }

     public static void main()
     {
         Console.WriteLine("Syöttö numero");
         int j = Convert.ToInt32(Console.ReadLine());
         for (int i = 1 ; i <= 10; i++) 
        
         {
         Console.WriteLine("{1} X {0} = {2}",i,j,i*j);
         Console.ReadLine();
         }    
     }

     public static void main()
     {
            
     }



}

