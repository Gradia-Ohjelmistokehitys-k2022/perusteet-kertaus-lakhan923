// See https://aka.ms/new-console-template for more information

// Ensimmäinen tehtävää!

        int age;
            string gender;

            Console.Write("Enter your gender (male/female): ");
            gender = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            
        if (age >= 1 && age <= 14)
        {
                if (gender == "male")
                {
                    Console.WriteLine("mitä poistu.");
                }
                else
                {
                    Console.WriteLine("Mitä tyttö.");
                }
        }  

        if (age >= 15 && age <= 25)    
        {
                if (gender == "male")
                {
                    Console.WriteLine("Mitä nuorimies.");
                }
                else
                {
                    Console.WriteLine("Mitä nuorinainen.");
                }
        }   

         if (age >= 26 && age <= 56)    
        {
           if (gender == "male")
               {
                Console.WriteLine("Olet mies parhaassa iässä.");
               }
            else
               {
                    Console.WriteLine("Olet nainen parhaassa iässä.");
               }
        }

//---------------------------------------------------------------------------------------------------------------

// Toinen tehtävää!

          int numb1; 
          int numb2;
          Console.Write("Input 1st number: ");  
          numb1= Convert.ToInt32(Console.ReadLine());  
          
          Console.Write("Input 2nd number: ");  
          numb2= Convert.ToInt32(Console.ReadLine());  
           
           if (numb1 >= numb2)
           {

               Console.WriteLine("Number 1 is greater.");
           }
           else
           {
               Console.WriteLine("Number 2 is greater.");
           }

           if (numb1 == numb2)
          {
          Console.WriteLine("numbers are equal.\n",numb1,numb2);
          }
          else
          {
          Console.WriteLine("numbers are not equal.\n",numb1,numb2);
          }
//---------------------------------------------------------------------------------------------------------------

// Kolmas tehtävää!

        int number;
        Console.Write("Input 1st number: ");  
        number= Convert.ToInt32(Console.ReadLine()); 
        
        number = number % 2;
        if (number == 0)
        {
             Console.WriteLine("It is an even integer.\n",number);
        }
            else
            {
            Console.WriteLine("It is an odd integer.\n",number);
            }

//---------------------------------------------------------------------------------------------------------------
// Neljäs tehtävää!

        Console.WriteLine("Is the sun shining (Y/N): ");
        string ans1 = Console.ReadLine();

        Console.WriteLine("Is it raining (Y/N): ");
        string ans2 = Console.ReadLine();
        
        Console.WriteLine(" Is the temperature > 0 (Y/N): ");
        string ans3 = Console.ReadLine();

        
        if(ans1 == "Y"  && ans2 == "Y" && ans3 == "Y")
        {
            Console.WriteLine("The sun is shining and it's raining, I think it's summer.");
        } else if(ans1 == "N" && ans2 == "Y" &&  ans3 == "Y") 
        {
            Console.WriteLine("Autumn arrived, the leaves were blown away by the wind.");
        }
        if(ans1 == "N" && ans2 == "N" &&  ans3 == "Y") 
        {
            Console.WriteLine("I already had to have a lovely time and a sweet summer.");
        }
        else if(ans1 == "Y" && ans2 == "N" &&  ans3 == "Y") 
        {
            Console.WriteLine("I already had to have a lovely time and a sweet summer.");
        }
