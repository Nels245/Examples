// // Задача 17. Определеяем плокскость точки по её координатам
// Console.Clear();
// int x,y;

// try
// {
//     Console.Write("Введите Х: ");
//     x = int.Parse(Console.ReadLine() ?? "");

//     Console.Write("Введите Y ");
//     y = int.Parse(Console.ReadLine() ?? "");
// }
// catch(Exception exc) //Все виды исключений являются наследниками класса эксепшион
// {
//     Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
//     return;
// }


// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Ошибка! Точка попадает на оси координат!)");
//}


//-------------------------------------------------------------------------------------------------------------


//Задача 19
//Напишите программу, которая по заданному номеу етверти
//показывает диапазон возможных координат (х и у)

// static void Quarter(int quarter) //указываем тип принимаемых данных, у нас это int - номер четверти
// {
//     if (quarter == 1)
//         Console.WriteLine("x > 0 и y > 0");
//     else if (quarter ==2)
//         Console.WriteLine("x < 0 и y > 0");
//     else if (quarter ==3)
//         Console.WriteLine("x < 0 и y < 0");
//     else if (quarter ==4)
//         Console.WriteLine("x > 0 и y < 0");
//     else
//         Console.WriteLine("Укажите корректно четверть.");
// }


// int quarter;

// Console.Write("Введите номер четверти: ");
// quarter = int.Parse(Console.ReadLine() ?? "");

// Quarter(quarter); //вызываем метод


//-------------------------------------------------------------------------------------------------------------


//Задача 21. Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве

// Console.Clear();
// int a1, a2, b1, b2;

// a1 = Cords("Введите координату x первого числа: ");
// a2 = Cords("Введите координату y первого числа: ");
// b1 = Cords("Введите координату x второго числа: ");
// b2 = Cords("Введите координату y второго числа: ");

// double distanse = getdistance(a1, a2, b1, b2); //вводим переменную distance сразу при выводе
// Console.WriteLine(distanse); // выводим то, что вычислил метод getdistance

// static int Cords(string message) //1 параметр - сообщеие ользователю
// {
//     Console.Write(message); // метод - принимаем строку от пользователя
//     int result = int.Parse(Console.ReadLine() ?? ""); //резалт введеное пользователем значение
//     return result;
// }

// static double getdistance(int a1, int a2, int b1, int b2) //метод поиска расстояния
// {
//     double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2)); //Pow- квадрат
//     return result;
// }


//-------------------------------------------------------------------------------------------------------------------------------

// Задача 22. Напишите программу, которая принимает на вход 
//число N и выдает таблицу квадратов чисел от 1 д до N
Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.Write("-> ");
PrintSquares(n); //Вызов

//////////////////// Логика
static void PrintSquares(int n)
{
    for(int i=1; i < n; i++)
    {
        Console.Write($"{i*i}, "); // либо  Math.Pow(i,2)
    }
    Console.Write($"{n*n}."); //выводи последнее n чтобы от запятой избавится

}

//-------------------------------------------------------------------------------------------











