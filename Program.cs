using System;
using System.Drawing;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int stepen = 0;
            // Цикл для обработки чисел
            while (true)
            {
                // Запрос числа у пользователя
                Console.Write("Введите число от 1 до 10: ");
                try
                {
                    // Преобразование строки в число
                    number = Convert.ToInt32(Console.ReadLine());
                    // Проверка, что число вы нужном диапазоне
                    if (number < 1 || number > 10)
                    {
                        // Число не в диапазоне, вывод сообщения об ошибке и пропуск итерации
                        Console.WriteLine("Ошибка! Число находится вне допустимого диапазона!");
                        continue;
                    }
                    else
                    {
                        // Запрос степени
                        Console.Write("Введите степень числа(от 0 до 9): ");
                        // Преобразование степени в число
                        stepen = Convert.ToInt32(Console.ReadLine());
                        // Проверка степени на соответствие условиям
                        if (stepen < 0 || stepen > 9)
                        {
                            // Степень не в диапазоне, вывод сообщения об ошибке и пропуск итерации
                            Console.WriteLine("Ошибка! Степень больше допустимого диапазона!");
                            continue;
                        }
                        else
                        {   
                            // Вывод результата с расчетом степени
                            Console.WriteLine("Число " + number + " в степени " + stepen + " равно " + SQR(number, stepen));
                        }
                    }
                }
                catch (Exception)
                {

                }
                
            }
        }
        // Функция вычисления степени
        public static int SQR(int number, int stepen)
        {
            // Выходное число с которым будут производиться операции
            int OutputNumber = number;
            // Цикл возведения в степень
            for (int i = 1; i < stepen; i++)
            {
                OutputNumber *= number;
            }
            // Возврат числа возведенного в степень
            return OutputNumber;
        }
    }
}
