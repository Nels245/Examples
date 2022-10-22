// Задача 39. Перевернуть одномерный массив [12345] - [54321]
// Console.Clear();

// int[] array = GetArray(10,0,10);
// Console.WriteLine(String.Join(" ", array)); // String.Join - метод join определенный на классе стринг 
// //1 - аргумент - разделитель 2 - массив который будем выводить

// int[] reversArray = ReversArray1(array); //метод reversarray1 ввернет нам развернутый ассив reversearray
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray2(array);
// Console.WriteLine(String.Join(" ", array));

// //Логика--------------------------------------------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int [size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return res;
// }

// int[] ReversArray1(int[] inArray) //первый способ переворота
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length -1 -i]; //переворот
//     }
//     return result;
// }

// void ReversArray2(int[] inArray) // второй способ переворота
// {
//     for (int i = 0; i < inArray.Length / 2; i++) //перебираем пополам (будет меньше операций в цикле for)
//     {
//         int k = inArray[i]; //это наш массив до середины
//         inArray[i] = inArray[inArray.Length -i -1]; // а тут переписываем старое значение (k это буффер)
//         inArray[inArray.Length -i -1] = k; // а поледний элемент у нас становится равен k, т.е первому элементу
//     }
// }

// второй вариант позволяет расходывать меньше оперативки

//Задача 40. Принимает 3 числа и првоеряет есть ли треугольник такой
//каждая сторона треугольника меньше сумму двух других

// int [] triangle = new int [3];

// // Логика -------------------------------------------------------

// for (int i = 0; i < triangle.Length; i++)//Вводим стороны треугольника
// {
//     Console.WriteLine("Введите длину стороны: ");
//     triangle[i] = int.Parse(Console.ReadLine() ?? "");
// }

// TriangleExist(triangle);

// void TriangleExist(int[] triangle)//метод првоерки существования треугольника
// {
//     int count = 0;
//     if (triangle[0] + triangle[1] > triangle[2])
//     {
//         count += 1;
//     }
//     if (triangle[0] + triangle[2] > triangle[1])
//     {
//         count += 1;
//     }
//     if (triangle[1] + triangle[2] > triangle[0])
//     {
//         count += 1;
//     }

//     if (count == 3)
//     Console.WriteLine("Существует");
//     else
//     Console.WriteLine("Не существует");
// }

//Задача 42. ПРеобразовывает десятичное числ ов двоичное

int s = 3;

int ss = 3;
//Логика ---------------------------------------------------------------

//int[] second = new int [];
while (s > 1)
{
    if (s == 2)
    {
        Console.Write('1');
        break;
    }
    int ost = s % 2;
    Console.Write(ost);
    s = s / 2;
    if (s / 2 == 0)
        break;
}
if (ss % 2 == 0)
Console.Write("0");
else
Console.Write("1");
//


//Нельзя сравнивать между собой вещественные числа double и double
//т.к комп хранит их не как 2.5 а например как 2.5000001 или 2.3999999