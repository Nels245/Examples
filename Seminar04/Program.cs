// Задача 24. Принимает число, и выдает сумму чисел от 1 до А
// Console.Clear();
// int num = GetNumberFromUser("Введите целое число А: ","Ошибка ввода!");
// int sumNumbers = GetSumNumbers(num);
// Console.WriteLine($"{num} -> {sumNumbers}");

// // Логика --------------------------------------------------------------------------------------

// int GetNumberFromUser(string message, string errorMessage)
// {
//     while(true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber); //Трай парс пытается строку преобразовать в тот тип в котормо он вызван, в данном случае тип int
//         //Консоль рид лайн закинет число в userNumber - тюк мы написали Out int
//         if (isCorrect)// если bool itCorrect true - нам вернет userNumder, а если false - выведет errorMessage
//             return userNumber;     //isCorrect тоже самое что и isCorrect = true
//         Console.WriteLine(errorMessage);//тут должен быть else, но т.к его нет просто переходим к следующей строке
//         //и пока не true, цикл будет переходить назад к while, т.е пока не введем message true
//     }
// }

// int GetSumNumbers(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum += number;
//         number--; // cуммируем от a до 0 (т.е в оьратном порядке)
//     }
//     return sum;
// }

//Задача 26. Напишите программу, которая принимает на вход исло и выдвет количество цифр в числе
// Console.Clear();

// int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
// int countNumbers = countNumber(num);
// Console.WriteLine($"{num} -> {countNumbers}");

// //Логика ---------------------------------------------------------------------------

// int GetNumberFromUser(string message, string errorMessage)
// {
// while(true)
//         {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
//         if (isCorrect)
//             return num;     
//         Console.WriteLine(errorMessage);
//         }
// }

// int countNumber(int num)
// {
//     int count = 1;
//     while (true) //вызываем бесконечный цикл
//     {
//         while (num > 9) //123
//         {
//             count += 1;
//             num = num / 10; 
//         }
//         return count;
//     }
// }

// //Задача 26. Напишите программу, которая принимает на вход число и находит произвдеение цифр в числе
// Console.Clear();

// int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
// int factorial = fact(num);
// Console.WriteLine($"{num} -> {factorial}");

// //Логика ---------------------------------------------------------------------------

// int GetNumberFromUser(string message, string errorMessage)
// {
// while(true)
//         {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
//         if (isCorrect)
//             return num;     
//         Console.WriteLine(errorMessage);
//         }
// }

// int fact(int num) //метод возвращает факториал числа
// {
//     int factor = 1;
//     int i = 1;
//     while (i <= num) //вызываем бесконечный цикл
//     {
//         factor = factor * i;
//         i++;   
//     }
//     return factor;
// }

//Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненый нулями и единицами в случайнмо порядке
Console.Clear();

int [] array = new int[8]; //выделяем память - new int 
FillArray(array); // заполнили массив
PrintArray(array);  // вывели массив



//Логика ---------------------------------------------------------------------------

void FillArray(int [] array) //заполняем массив
{
    int i = 0;
    int len = array.Length;
    while(i < len)
    {
        array[i] = new Random().Next(0,2);
        i++;    
    }
}

void PrintArray(int [] array) //выводим массив
{
    int i = 0;
    int len = array.Length;
    while (i < len)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}
