/*
Часть 1.

	Основное требование - необходимо организовать структуру классов таким образом, 
        чтобы функционал можно было легко расширять и вносить изменения.
		
	1. В приложение приходит коллекция значений от 0 до 17 которые необходимо преобразовать (GetTestData1()).

	2. Значения кратные 3 заменяем на слово "Fizz", а значения кратные 5 на слово "Buzz". 
		Если занчение кратно и 3 и 5 заменяем на слово "FizzBuzz". 
        Отсутствующие совпадения отбрасываем. 

	3. Полученный результат необходимо вывести в консоль.


Часть 2.

    1. На входе, получаем коллекцию элементов string (GetTestData3()).
        Заменяем значения если строка содержит:
       '0' заменяем строку на 'Fizz'
       '1' заменяем строку на 'Buzz'
       '0' и '1' заменяем строку на 'FizzBuzz'
       Если строка не содержит ни '0' ни '1' возвращаем значение без изменений
   
    2. На входе принимаем коллекцию int (GetTestData2()), но в конвертере заменяем значения:
       кратные 2 на 'Fizz'
       кратные 4 на 'Buzz'
       кратные 6 на 'FizzBuzz'
       Отсутствующие совпадения отбрасываем.

    3. При выводе на консоль необходимо изменить цвет текста для строк:
       "Fizz" - Yellow
       "Buzz" - Red
       "FizzBuzz" - Cyan
   
    4. Помимо вывода в консоль, полученный результат необходимо 
        записать в файл /FizzBuzz/"StringToFizzBuzz.txt" 
        (Если файл уже существует - перезаписываем его).


После реализации, возможно необходимо будет расширить функционал. 
*/

using System;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutingService executingService = new ExecutingService();
            // Задание №1

            Console.WriteLine("\n Задание 1 \n");

            executingService.showResultTestData1();

            ////Задание №2.1

            Console.WriteLine("\n Задание 2.1 \n");

            executingService.showResultTestData3();

            ////Задание №2.2

            Console.WriteLine("\n Задание 2.2 \n");

            executingService.showResultTestData2();

            Console.BackgroundColor = default;

            ////Задание №2.4

            executingService.writeToFile();

            Console.ReadLine();

        }
    }
}
