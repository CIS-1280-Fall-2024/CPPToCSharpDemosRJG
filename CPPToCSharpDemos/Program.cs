namespace CPPToCSharpDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //say hello to name

            Console.WriteLine("Hello, "+name+"!");

            //wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
