using System;

class Program
{
    static void Main()
    {
        // Создаем массив строк
        string[] strings = { "apple", "banana", "cherry", "date", "fig", "grape" };

        // Запрашиваем у пользователя новую строку
        Console.Write("Введите строку для поиска: ");
        string input = Console.ReadLine();

        // Проверяем, содержится ли введенная строка в массиве
        bool found = false;
        foreach (string str in strings)
        {
            if (str == input)
            {
                found = true;
                break;
            }
        }

        // Выводим сообщение в зависимости от результата поиска
        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}
