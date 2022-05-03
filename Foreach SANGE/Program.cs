namespace ConsoleApp3

{

    class Program

    {

        static void Main(string[] args)

        {

            string[] Sange = { "Old time road", "Paris", "SOS", "So Am I" };



            Console.WriteLine("Her er mine ynglingssange");



            foreach (string sang in Sange )
            {
                Console.WriteLine(sang);
            }

            Console.ReadKey();



        }

    }

}