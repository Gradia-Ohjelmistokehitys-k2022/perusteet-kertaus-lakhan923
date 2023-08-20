namespace Task_3_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<int> numbers = new();
            Console.WriteLine("Enter 5 numbers: ");


            for (int i = 0; i < 5; i++)
            {
                int read = Convert.ToInt32(Console.ReadLine());
                numbers.Add(read);
            }

            Console.WriteLine("KeskiArvo on: " + KeskiArvo(numbers));
            Console.WriteLine("Mediani on: " + Mediani(numbers));

        }

        public static double Mediani(List<int> numbers)
        {

            var midi = numbers.Count() / 2;

            if (numbers.Count() % 2 == 0)
                return (numbers[midi] + numbers[midi - 1]) / 2.0;

            return numbers[midi];
        }

        public static double KeskiArvo(List<int> numbers)
        {
            double keskiarvo;
            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            keskiarvo = sum / (numbers.Count - 0);
            return keskiarvo;
        }
    }
}
