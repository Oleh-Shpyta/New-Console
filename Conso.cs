string game = "шибениця";
char[] display = new string('_', game.Length).ToCharArray();
int wrong = 0;
int maxWrong = 6;

Console.WriteLine("Гра \"Шибениця\"");
Console.WriteLine($"Слово має {game.Length} літер. У вас є {maxWrong} спроб.\n");

while (wrong < maxWrong)
{
    Console.WriteLine("Поточний стан слова: " + new string(display));
    Console.WriteLine($"Невірні спроби: {wrong}/{maxWrong}");
    Console.Write("Введіть літеру: ");
    string input = Console.ReadLine();

    if (input.Length == 1 && char.IsLetter(input[0]))
    {
        char letter = char.ToLower(input[0]);
        bool correct = false;

        for (int i = 0; i < game.Length; i++)
        {
            if (game[i] == letter && display[i] != letter)
            {
                display[i] = letter;
                correct = true;
            }
        }
        if (!correct)
        {
            wrong++;
        }

        if (new string(display) == game)
        {
            Console.WriteLine("\nВи виграли!");
            Console.WriteLine($"Слово: {game}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Будь ласка, введіть лише одну літеру.");
    }
}
if (wrong >= maxWrong)
{
    Console.WriteLine("\nВи програли.");
    Console.WriteLine($"Слово було: {game}");
}
