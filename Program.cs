using Rutinerede_Opgaver;

class Program
/* // Opgave. A.1
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello world");
    }
    
}
*/
/*  // Opgave A.2
{
    static void Main (string[] args)
    {
        string navn = "Louis";
        Console.WriteLine($"mit navn er: {navn}");
    }
}
*/
/*  // Opgave A.6
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Velkommen til lommeregneren");
        Console.WriteLine("Vælg det tegn du vil udføre: +, -, *, /");
        string tegn = Console.ReadLine();

        Console.WriteLine("Vælg det første tal");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vælg det andet tal");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double resultat = 0;

        switch (tegn)
        {
            case "+":
                resultat = firstNumber + secondNumber;
                break;
            case "-":
                resultat = firstNumber - secondNumber;
                break;
            case "*":
                resultat = firstNumber * secondNumber;
                break;
            case "/":
                resultat = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Ugyldigt tegn! Prøv igen.");
                return;
        }
        Console.WriteLine($"Resultat: {resultat}");
    }
}
*/
/*  // Opgave A. 17
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast dit navn:");
        string navn = Console.ReadLine();
        Console.WriteLine("Indtast dit alder:");
        string alderInput = Console.ReadLine();

        double alder = Convert.ToDouble(alderInput);

        Console.WriteLine($"Dit navn er {navn} og du er {alder} år gammel.");

    }
}
*/
/*  // Opgave A. 18
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast et tal mellem 1 og 10, for at begynde at gætte.");
        int correctNumber = Convert.ToInt32(Console.ReadLine());
        bool correctGuess = false;

        while (!correctGuess)
        {
            string input = Console.ReadLine();
            int guess;

            if (int.TryParse(input, out guess) && guess == correctNumber)
            {
                Console.WriteLine("Du har gættet rigtigt, tillykke.");
                correctGuess = true;
            }
            else
            {
                Console.WriteLine("Forkert, Prøv igen.");
            }
        }
    }
}
*/
/*  // Opgave B. 4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast det beløb i danske kroner du ønsker at omregne til euro");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double amountDk))
        {
            double euros = ValutaOmregner.ConvertToEuro(amountDk);
            Console.WriteLine($"Du indtastede {amountDk} som er lig med {euros:F2} euro");
        }
        else
        {
            Console.WriteLine("prøv igen");
        }
    }

}
*/
namespace GætEtTalSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            Game game = new Game(numberToGuess);
            game.Play();
        }
    }
}
