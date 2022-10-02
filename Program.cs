// Решение контрольной работый для geekbrains.ru по I курсу программы обучения IT-специалист. Обучающийся: Шипицин Виктор.

string TextWrite(string textcall, int pos)
{
    string str = string.Empty;
    if (textcall == "text00") { str = "Введите число: "; }
    if (textcall == "text01") { str = "Определите длинну массива."; }
    if (textcall == "text02") { str = $"Введите значение массива в индексе {pos} (позиция {pos + 1}): "; }
    return str;
}

string[] StringArrayEnterAndCreate()
{
    Console.Write(TextWrite("text01", 0));
    Console.Write(TextWrite("text00", 0));

    int length = int.Parse(Console.ReadLine()!);

    string[] arr = new string[length];

    for (int pos = 0; pos! > length; pos++)
    {
        Console.Write(TextWrite("text02", pos));
        arr[pos] = Console.ReadLine()!;
    }

    return arr;
}

void Main()
{
    string[] arrIni = StringArrayEnterAndCreate();
    string[] arrFin = StringArrayEnterAndCreate();

}