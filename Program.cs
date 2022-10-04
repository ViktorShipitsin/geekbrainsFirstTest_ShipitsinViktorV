// Решение контрольной работый для geekbrains.ru по I курсу программы обучения IT-специалист. Обучающийся: Шипицин Виктор.

namespace OneNamespace
{
    class OneClass
    {
        static string TextWrite(string textcall, int val)
        {
            string str = string.Empty;
            if (textcall == "text00") { str = "Введите число: "; }
            if (textcall == "text01") { str = "Определите длинну массива. "; }
            if (textcall == "text02") { str = $"Введите значение массива в индексе {val} (позиция {val + 1}): "; }
            if (textcall == "text03") { str = "Принят заданный массив, содержащий строки: "; }
            if (textcall == "text04") { str = $"Массив содержит строки из трёх и менее знаков, в количестве: {val}. "; }
            if (textcall == "text05") { str = "Вот вышеозначенные строки: "; }
            if (textcall == "text06") { str = "Массив не содержит строк из трёх и менее знаков."; }
            return str;
        }

        static string[] StringArrayEnterAndCreate()
        {
            Console.Write(TextWrite("text01", 0));
            Console.Write(TextWrite("text00", 0));

            int length = int.Parse(Console.ReadLine()!);

            string[] arr = new string[length];

            for (int pos = 0; pos < length; pos++)
            {
                Console.Write(TextWrite("text02", pos));
                arr[pos] = Console.ReadLine()!;
            }

            Console.WriteLine();

            return arr;
        }

        static void StringArrayThreeOrLessCharSel(string[] arrayInp)
        {
            Console.Write(TextWrite("text03", 0));
            PrintArray(arrayInp, arrayInp.Length);
            Console.WriteLine();

            int length = 0;

            for (int i = 0; i < arrayInp.Length; i++)
            {
                if (arrayInp[i].Length <= 3) { length++; }
            }

            if (length > 0)
            {
                Console.Write(TextWrite("text04", length));
                Console.Write(TextWrite("text05", 0));

                string[] arrayOut = new string[length];
                int curPos = 0;

                for (int i = 0; i < arrayInp.Length; i++)
                {
                    if (arrayInp[i].Length <= 3)
                    {
                        arrayOut[curPos] = arrayInp[i];
                        curPos++;
                    }
                }

                PrintArray(arrayOut, length);
            }

            else { Console.Write(TextWrite("text06", 0)); }
        }

        static void PrintArray(string[] array, int comNum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (comNum > 1) { Console.Write(", "); }
                else { Console.Write("."); }
                comNum--;
            }
        }

        static void Main()
        {
            StringArrayThreeOrLessCharSel(StringArrayEnterAndCreate());
        }
    }
}