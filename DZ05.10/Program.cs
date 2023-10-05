using System;

namespace DZ4
{
    internal class Program
    {
        enum GrouchinessLevel
        {
            Высокий,
            Умеренный,
            Средний,
            Очень_высокий,
            Маленький

        }
        struct DED
        {
            public string name;
            public GrouchinessLevel grouchinessLevel;
            public int quantityOfBruises;
            public string[] grumblingPhrases;
            public int ComparePhrases(params string[] cursingWords)
            {

                int quantityOfBruises = 0;
                foreach (string word in grumblingPhrases)
                {
                    foreach (string badWord in cursingWords)
                    {
                        if (badWord == word)
                        {
                            quantityOfBruises += 1;
                        }
                    }
                }

                return quantityOfBruises;
            }
        }
        static int ArrayNumbers(ref int product, out double averageValue, params int[] arrayvalues)
        {
            int sum = 0;

            foreach (int number in arrayvalues)
            {
                sum += number;
                product *= number;
            }

            averageValue = (double)sum / arrayvalues.Length;

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Console.WriteLine("Исходный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("Введите индекс первого элемента для обмена: ");
            if (int.TryParse(Console.ReadLine(), out int index1))
            {
                if (index1 < 0 || index1 >= 20)
                {
                    Console.WriteLine("Такого индекса в массиве нет");
                    Console.WriteLine("Для завершения нажмите Enter");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }


            Console.Write("Введите индекс второго элемента для обмена: ");
            if (int.TryParse(Console.ReadLine(), out int index2))
            {
                if (index2 < 0 || index2 >= 20)
                {
                    Console.WriteLine("Такого индекса в массиве нет");
                    Console.WriteLine("Для завершения нажмите Enter");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            Console.WriteLine("Получившийся массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 2");
            int sum;
            double averageValue;
            int product = 1;


            Random random1 = new Random();
            int[] arrayvalues = new int[5];
            for (int i = 0; i < arrayvalues.Length; i++)
            {
                arrayvalues[i] = random.Next(1, 10);
            }
            Console.WriteLine("Исходный массив:");
            foreach (int num in arrayvalues)
            {
                Console.Write(num + " ");
            }
            sum = ArrayNumbers(ref product, out averageValue, arrayvalues);
            Console.WriteLine($"\nСумма чисел массива равна {sum}\nПроизведение {product}\nСреднее арифметическое {averageValue}");
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadKey();

            Console.WriteLine("Упражнение 4");
            string[] cursingWords = { "Проститутки", "Гады", "Пиндосы", "Мрази", "пидоры", "ебанутые", "пидорасы" };
            string[] PetyaGrumblingPhrases = { "Проституки", "Гады", "пидорасы", "нефоры" };
            string[] DimaGrumblingPhrases = { "Проститутки", "Гады", "пидоры" };
            string[] AlexanderGrumblingPhrases = { "Проститутки", "Дибилы", "Поганцы" };
            string[] ValeraGrumblingPhrases = { "Гады", "Черти" };
            string[] VityaGrumblingPhrases = { "Паразиты" };

            DED Petya = new DED();
            Petya.name = "Петрович";
            GrouchinessLevel Petyagrouchinglevel = GrouchinessLevel.Высокий;
            Petya.grouchinessLevel = Petyagrouchinglevel;
            Petya.grumblingPhrases = PetyaGrumblingPhrases;
            Petya.quantityOfBruises = Petya.ComparePhrases(cursingWords);


            DED Dima = new DED();
            Dima.name = "Димон";
            GrouchinessLevel DimagrouchinessLevel = GrouchinessLevel.Очень_высокий;
            Dima.grouchinessLevel = DimagrouchinessLevel;
            Dima.grumblingPhrases = DimaGrumblingPhrases;
            Dima.quantityOfBruises = Dima.ComparePhrases(cursingWords);

            DED Alexander = new DED();
            Alexander.name = "Саня";
            GrouchinessLevel AlexandergrouchinessLevel = GrouchinessLevel.Умеренный;
            Alexander.grouchinessLevel = AlexandergrouchinessLevel;
            Alexander.grumblingPhrases = AlexanderGrumblingPhrases;
            Alexander.quantityOfBruises = Alexander.ComparePhrases(cursingWords);

            DED Valera = new DED();
            Valera.name = "Валера";
            GrouchinessLevel ValerargrouchinessLevel = GrouchinessLevel.Средний;
            Valera.grouchinessLevel = ValerargrouchinessLevel;
            Valera.grumblingPhrases = ValeraGrumblingPhrases;
            Valera.quantityOfBruises = Valera
                .ComparePhrases(cursingWords);


            DED Vitya = new DED();
            Vitya.name = "Витя";
            GrouchinessLevel VityagrouchinessLevel = GrouchinessLevel.Маленький;
            Vitya.grouchinessLevel = VityagrouchinessLevel;
            Vitya.grumblingPhrases = VityaGrumblingPhrases;
            Vitya.quantityOfBruises = Vitya.ComparePhrases(cursingWords);


            Console.WriteLine($"Дед {Dima.name} имеет {Dima.quantityOfBruises} фингалов");
            Console.WriteLine($"Дед {Petya.name} имеет {Petya.quantityOfBruises} фингалов");
            Console.WriteLine($"Дед {Alexander.name} имеет {Alexander.quantityOfBruises} фингалов");
            Console.WriteLine($"Дед {Valera.name} имеет {Valera.quantityOfBruises} фингалов");
            Console.WriteLine($"Дед {Vitya.name} имеет {Vitya.quantityOfBruises} фингалов");



            Console.WriteLine("Для завершения нажмите Enter");
            Console.ReadKey();





        }
    }
}