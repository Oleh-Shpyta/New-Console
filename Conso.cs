string game = "��������";
char[] display = new string('_', game.Length).ToCharArray();
int wrong = 0;
int maxWrong = 6;

Console.WriteLine("��� \"��������\"");
Console.WriteLine($"����� �� {game.Length} ����. � ��� � {maxWrong} �����.\n");

while (wrong < maxWrong)
{
    Console.WriteLine("�������� ���� �����: " + new string(display));
    Console.WriteLine($"����� ������: {wrong}/{maxWrong}");
    Console.Write("������ �����: ");
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
            Console.WriteLine("\n�� �������!");
            Console.WriteLine($"�����: {game}");
            break;
        }
    }
    else
    {
        Console.WriteLine("���� �����, ������ ���� ���� �����.");
    }
}
if (wrong >= maxWrong)
{
    Console.WriteLine("\n�� ��������.");
    Console.WriteLine($"����� ����: {game}");
}
