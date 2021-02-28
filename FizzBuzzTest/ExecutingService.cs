using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    public class ExecutingService : IExecutingService
    {
  

        List<string> tempResult = new List<string>();

        TestDataService testService = new TestDataService();
        public List<string> resultTestData1(IEnumerable<int> temp)
        {
            List<string> result = new List<string>();

            foreach(var i in temp)
            {
                if(i % 3 == 0 && i % 5 == 0) result.Add($"Замена от числа {i} = FizzBuzz");

                else if (i % 3 == 0) result.Add($"Замена от числа {i} = Fizz"); 

                else if(i % 5 == 0) result.Add($"Замена от числа {i} = Buzz");

            }
            return result;
        }

        public void showResultTestData1()
        {
            var dataTestData1 = testService.GetTestData1();

            foreach (var i in dataTestData1)
            {
                Console.WriteLine($"Число = {i}");
            }

            Console.WriteLine("\n");

            tempResult = resultTestData1(dataTestData1);

            foreach (var i in tempResult)
            {
                Console.WriteLine(i);
            }
        }

        public List<string> resultTestData3(IEnumerable<string> temp)
        {
            List<string> result = new List<string>();

            foreach(var i in temp)
            {
                if (i.Contains('0') && i.Contains('1')) result.Add($"Замена от строки {i} = FizzBuzz");

                else if (i.Contains('0')) result.Add($"Замена от строки {i} = Fizz");

                else if (i.Contains('1')) result.Add($"Замена от строки {i} = Buzz");

                else result.Add($"Строка без изменений {i}");
            }
            return result;
        }

        public void showResultTestData3()
        {
            var dataTestData3 = testService.GetTestData3();

            foreach (var i in dataTestData3)
            {
                Console.WriteLine($"Cтрока = {i}");
            }

            Console.WriteLine("\n");

            tempResult = resultTestData3(dataTestData3);

            foreach (var i in tempResult)
            {
                Console.WriteLine(i);
            }

        }

        public List<string> resultTestData2(IEnumerable<int> temp)
        {
            List<string> result = new List<string>();

            foreach (var i in temp)
            {
                if (i % 6 == 0) result.Add($"Fizz");

                else if (i % 4 == 0) result.Add($"Buzz");

                else if (i % 2 == 0) result.Add($"FizzBuzz");

            }
            return result;
        }

        public void showResultTestData2()
        {
            var dataTestData2 = testService.GetTestData2();

            foreach (var i in dataTestData2)
            {
                Console.WriteLine($"Число = {i}");
            }

            Console.WriteLine("\n");

            tempResult = resultTestData2(dataTestData2);

            foreach (var i in tempResult)
            {

                if (i == "Fizz") { Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine(i); }

                else if (i == "Buzz") { Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine(i); }

                else if (i == "FizzBuzz") { Console.BackgroundColor = ConsoleColor.Cyan; Console.WriteLine(i); }
            }
        }

        public void writeToFile()
        {
            try
            {
                string path = @"C:\";

                var dataTestData2 = testService.GetTestData2();

                tempResult = resultTestData2(dataTestData2);
           
                using (FileStream fstream = new FileStream($"{path}StringToFizzBuzz.txt", FileMode.OpenOrCreate))
                { 
                    foreach(var i in tempResult)
                    {
                        byte[] array = Encoding.Default.GetBytes(i+"\n");

                        fstream.Write(array, 0, array.Length);
                    }

                 Console.WriteLine("\nТекст записан в файл");
                }
            }
            catch
            {
                Console.WriteLine("\nУпс, ошибка");
            }
        }
    }
}
