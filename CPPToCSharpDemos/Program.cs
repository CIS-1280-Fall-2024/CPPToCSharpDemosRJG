namespace CPPToCSharpDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get name
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //say hello to name

            //Console.WriteLine("Hello, "+name+"!");


            //display numbers and strings
            decimal cost = 12.45M;
            int index = 5;
            Console.WriteLine("The cost is {0:C} and the index is {1}.", cost, index);
            Console.WriteLine($"The cost is {cost:C} and the index is {index}.");
            string text = $"The cost is {cost:C} and the index is {index}.";

            double[] numbers = { 1.1234, 2.43200, 30.2340, 40.12340 };
            string[] names = { "Bob", "Susan", "Tom", "Annita" };
            Console.WriteLine($"{"index",-10} {"name",-20} {"number",-5}");
            for(int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(i.ToString()+names[i]+numbers[i]);
                Console.WriteLine($"{i,-10} {names[i],-20} {numbers[i],-5:f2}");
            }

            Console.WriteLine(text);
            //wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
