using System;

namespace LABWORK5
{

    internal class Program
    {
        public static long RecursiveFibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        public static int NOD(int a, int b)
        {

            while (b != 0)
            {

                a = a % b;

                var temp = a;

                a = b;

                b = temp;

            }

            return a;
        }
        public static int NOD3(int a, int b, int c)
        {
            int nod = NOD(a, b);
            int nod2 = NOD(nod, c);
            return nod2;
        }
        public static int Factorialless(int n)
        {

            if (n == 1) return 1;
            try
            {
                checked
                {
                    return n * Factorialless(n - 1);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение");
            }

            return 0;
        }
        static bool Factorial(int value, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= value; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        public static void SwapByRef(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите два целых числа: ");
            if (Int32.TryParse(Console.ReadLine(), out int n1) && Int32.TryParse(Console.ReadLine(), out int n2))
            {
                Console.WriteLine($"Максимально число из двух предложенных: {Max(n1, n2)}");
            }
            else
            {
                Console.WriteLine("Вы ввели неккоректные данные");
            }

            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();


            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Введите два любых значения: ");
            if (int.TryParse(Console.ReadLine(), out int value1) && int.TryParse(Console.ReadLine(), out int value2))
            {
                SwapByRef(ref value1, ref value2);
                Console.WriteLine($"Ваши значения после обмена: {value1}, {value2}");
            }
            else
            {
                Console.WriteLine("Введённые данные некорректны");
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 5.3");
            Console.Write("Введите число, факториал которого вы хотите найти: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine(Factorial(value, out long result));
                Console.WriteLine($"Факториал числа {value} равен {result}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
            Console.WriteLine("Для продолженеия нажмите Enter");
            Console.ReadKey();


            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите число, факториал которого вы хотите найти:");
            if (int.TryParse(Console.ReadLine(), out int valueless))
            {

                Console.WriteLine($"Факториал данного числа равен: {Factorialless(valueless)}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
            Console.WriteLine("Для продолженеия нажмите Enter");
            Console.ReadKey();


            Console.WriteLine("Домашнее задание 5.1 (2 нат. числа)");
            Console.WriteLine("Введите 2 натуральных числа:");
            if (int.TryParse(Console.ReadLine(), out int num1) && int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine($"НОД чисел: {NOD(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
            Console.WriteLine("Для продолженеия нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.1 (3 нат. числа)");
            Console.WriteLine("Введите 3 натуральных числа:");
            if (int.TryParse(Console.ReadLine(), out int number1) && int.TryParse(Console.ReadLine(), out int number2) && int.TryParse(Console.ReadLine(), out int num3))
            {
                Console.WriteLine($"НОД чисел: {NOD3(number1, number2, num3)}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
            Console.WriteLine("Для продолженеия нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("ДЗ 5.2");
            Console.Write("Введите номер n числа из ряда Фибаначчи: ");
            if (int.TryParse(Console.ReadLine(), out int valuefi))
            {
                Console.WriteLine($"Номеру {valuefi} соответствует число {RecursiveFibonacci(valuefi)}");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }
            Console.WriteLine("Для завершения нажмите Enter");
            Console.ReadKey();





        }
    }
}
