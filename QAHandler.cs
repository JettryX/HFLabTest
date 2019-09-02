using System;
using System.IO;
using System.Diagnostics;

namespace QAHandler
{
    class QAHandler
    {
        static int AcounterInString(string str) // Посчёт количества символов 'a' в строке
        {
            int Acounter = 0;
            foreach (char c in str)
            {
                if (c == 'a')
                    Acounter++;
            }
            return Acounter;
        }
        static int Lines_And_A_Counter(string filepath, out int Acounter)
        {
            Acounter = 0;
            string workstring;
            int lanecounter = 0; // Счётчик количества строк
            try
            {
                using (StreamReader sr = new StreamReader(filepath)) //Считывальщик файла.
                {
                    while ( (workstring=sr.ReadLine()) != null)
                    {
                        Acounter += AcounterInString(workstring);
                        lanecounter++;
                        /*  Обновление информации о количестве строк в реальном времени. Увеличивает длительность работы в десятки раз!!!
                            Console.Write("Current Number of strings: " + lanecounter); 
                            Console.Write('\r');
                        */
                    }
                }
                Console.Clear();
                return lanecounter;
            }
            catch (Exception e) // Если возникла ошибка
            {
                Console.WriteLine("The File could not be read:");
                Console.WriteLine(e.Message);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа создана для вычисления количества строк и символов 'a' для решения тестового задания в компанию HFLabs на должность: Стажёр QA ");
            Console.WriteLine("Работа выполнения кандидатом: Одиноков Алексей Александрович");
            Console.WriteLine("Для решения использовались следующие технологии: C# и .NET Framework 4.5");
            Console.WriteLine("Ожидайте, результат скоро будет :)");
            Stopwatch stopwatch = new Stopwatch(); //Таймер для определения длительности работы алгоритма
            stopwatch.Start(); 
            int strings;
            int As;
            string filepath = @"d:\\QATest\\QATest.txt"; // Путь к файлу. Изменить при необходимости.
            strings = Lines_And_A_Counter(filepath, out As); // Функция подсчёт количества строк и количества символов 'a'
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Полученные результаты: ");
            Console.WriteLine("Количество строк : " + strings); // Вывод количества строк
            Console.WriteLine("Количество символов 'a': " + As);
            Console.WriteLine("Результат получен за:" + stopwatch.Elapsed); // Вывод времени работы алгоритма.
            Console.Read();
        }
    }
}
