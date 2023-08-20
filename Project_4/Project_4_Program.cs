using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

// Ensimmäinen tehtävää!

System.Console.WriteLine("user input the number: ");
string value = Console.ReadLine();
int x;
Int32.TryParse(value, out x);

int[] numbers = new int[x];

for (int i = 0; i < x; i++)
{
  numbers[i] = i + 5;
}

foreach (int i in numbers)
{
  System.Console.WriteLine(i);
}


//----------------------------------------------------------------------------------------------------

// Toinen tehtävää!

int num = 10;
System.Console.WriteLine("Enter the starting number: ");
num = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}

for (int i = 1; i < num; i++)
{

  Console.WriteLine(i);
}

//----------------------------------------------------------------------------------------------------

// Kolmas tehtävää!

double avg;
int sum = 0;

List<int> numbers = new List<int> { };
Console.WriteLine("Read 5 numbers and calculate the average:\n");
Console.Write("\n\n");
//reads five integers from the keyboard and writes them to a list.

int intValue;
string input;
bool parsingSuccess;

//loop that runs 5 times.

for (int i = 0; i < 5; i++)
{
  Console.WriteLine("Please enter the integer number: ");
  input = Console.ReadLine();
  parsingSuccess = Int32.TryParse(input, out intValue);
  if (!parsingSuccess)
  {
    Console.WriteLine("The value entered was not a number");

  }
  else
  {
    numbers.Add(intValue);
  }
}

// finding the average using foreach.
foreach (int i in numbers)
{
  Console.WriteLine(i);
  sum += i;
}
avg = sum / numbers.Count;
Console.Write("Total average is: " + avg);

//----------------------------------------------------------------------------------------------------

// Neljäs tehtävää!

int value = 45;

int input;
int i = 1;
while (i <= 5)
{

  Console.WriteLine("input the number: ", i);
  input = Convert.ToInt32(Console.ReadLine());

  if (value == input)
  {
    System.Console.WriteLine("Good luck, same number!", input);
    break;

  }
  else if (value != input)
  {
    System.Console.WriteLine("Try again! ", input);

  }
  if (i == 5)
  {
    System.Console.WriteLine("5 rounds, end the program! ");

  }

  i++;
}

//----------------------------------------------------------------------------------------------------

// Viides tehtävää!
int total = 0;
int target = 0;
int sum = 1;

while (sum <= 100)
{
  Console.Write("Enter the number: ", sum);
  total += Convert.ToInt32(Console.ReadLine());
  sum++;
}

while (total == target) ;
Console.WriteLine("The limit has been reached!", sum, total);


