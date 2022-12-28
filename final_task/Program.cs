Console.WriteLine("Введите любой текст, слова или знаки через пробел");
string text = Console.ReadLine();
string[] Array = text.Split(' ');

Console.WriteLine("Короткие символы в вашем тексте: ");
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        Console.WriteLine($"[{Array[i]}]");
    }
}