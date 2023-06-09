Console.WriteLine("===Программа для вывода подстроки после первой точки===\n");
Console.WriteLine("Введите строку:");
int count = 0; // Счётчик для подсчёта точек
int count1 = 0; // Счётчик для запуска цикла подстроки
string str = Console.ReadLine(); // Ввод строки
string str_mod = ""; // Переменная для подстроки
string str_final = ""; // Переменная для подстроки
int length = str.Length; // Длина строки
bool isDot = false; // Наличие точки в строке

for (int i = 0; i < length; i++)
{
    str_mod += str[i];
    if (str[i] == '.')
    {
        count++;
        isDot = true;
        if (isDot && count1 == 0)
        {
            for (int k = i + 1; k < length; k++)
            {
                str_final += str[k];
            }
            count1++;
        }
    }
}

for (int j = 0; j < length; j++)
{
    if (count == 0)
    {
        System.Console.WriteLine($"{str_mod}: Точек нет");
        break;
    }
    else if (count == 1)
    {
        System.Console.WriteLine($"{str_mod}: Одна точка");
        break;
    }
    else
    {
        System.Console.WriteLine($"'Строка после первой точки': {str_final}");
        break;
    }
}