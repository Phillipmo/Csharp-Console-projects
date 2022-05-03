class Program
{
    static void Main(string[] args)
    {
        string name, password;

        name = "Steven";
        password = "Steven123";


        if (name == "Steven" && password == "Steven123")
        {


            Console.WriteLine("Login Successful");

        } else
        {
            Console.WriteLine("Unauthorised access");
        }

        Console.ReadLine();

    }

}