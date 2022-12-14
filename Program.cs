// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//string CreateArrayStr(int m)
void CreateArrayStr(int m)
{
    string arrayStr = String.Empty;
    string countSymbStr = String.Empty;
    string result = String.Empty;

    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} строку массива, затем нажмите Enter: ");
        countSymbStr = Console.ReadLine();
        if (i == 0)
        {
            arrayStr = "[";
        }

        if (i == m - 1)
        {
            arrayStr = $"{arrayStr}\"{countSymbStr}\"]";
        }
        else
        {
            arrayStr = $"{arrayStr}\"{countSymbStr}\", ";
        }

        if (countSymbStr.Length <= 3)
        {
            result = $"{result} \"{countSymbStr}\" ";
        }

    }
    Console.Write($"{arrayStr} -> [{result}]");

}


Console.Write("Введите количество элементов массива строк: ");
int m = Convert.ToInt32(Console.ReadLine());

CreateArrayStr(m);

