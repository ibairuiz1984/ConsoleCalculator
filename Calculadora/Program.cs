using System;

public class Program
{
    public static void Main()
    {
        
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.White;       
        //Console.Clear();

        string answer;

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        do
        {
            int num1 = 0;
            int num2 = 0;

            // Validar la entrada del primer número
            while (true)
            {
                Console.WriteLine("Type a number, and then press Enter");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Validar la entrada del segundo número
            while (true)
            {
                Console.WriteLine("Type another number, and then press Enter");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Preguntar al usuario que elija una opción
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\t0 - Exit");

            Console.Write("Your option? ");
            answer = Console.ReadLine();

            if (answer == "0")
            {
                break;  // Salir del bucle si el usuario elige "0"
            }

            switch (answer)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

            Console.WriteLine("\nDo you want to perform another operation? (y/n)");
            answer = Console.ReadLine();
            Console.Clear();

        } while (answer.ToLower() == "y");

        Console.WriteLine("Exiting...");
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey();

        // Restablecer los colores originales de la consola
        Console.ResetColor();
    }
}
