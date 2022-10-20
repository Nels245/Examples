// // Задача 31. Рандомный массив из 12 элементов (-9 до 9). Найти
// // сумму + и - чисел.
// Console.Clear();

// int [] array = GetArray(12, -9, 9); //кол-во элементов, старт и конец
// //сверху, создаем метод заполнения массива рамером 12, числами от -9 до 9

// PrintArray(array); //выводим массив

// int negativeSum = GetNegativeSum(array);//метод получения суммы отрицательных чисел
// Console.WriteLine($"\nСумма отрицательных чисел массива = {negativeSum}");

// int positiveSum = GetPositiveSum(array);//метод получения суммы отрицательных чисел
// Console.WriteLine($"\nСумма положительных чисел массива = {positiveSum}");
// // \n - перенос строки


// // Logic ----------------------------
// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++) //выводим наш массив
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] GetArray(int size, int minValue, int maxValue) //метод заполнения массива
// {
//     int[] res = new int[size];// задаем размер массива

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);//На обьекте класса Random вызываем метод Next
//     }



//     return res;
// }

// int GetNegativeSum(int[] array)
// {
//     int negativeSum = 0;
//     foreach(int el in array)//если внутри тела цикла понадобится конкретное значение без индекса можно использоваь foreach
//     //l - будет принимать текущее значение элемента на данной итерации
//     {
//         if (el<0) negativeSum += el;
//     }

//     return negativeSum;
        
// }

// int GetPositiveSum(int[] array)
// {
//     int positiveSum = 0;
//     foreach(int el in array)//если внутри тела цикла понадобится конкретное значение без индекса можно использоваь foreach
//     //l - будет принимать текущее значение элемента на данной итерации
//     {
//         if (el>0) positiveSum += el;
//     }

//     return positiveSum;
        
// }


//Задача 32. Заменить + эл массива на - и наоборот [-4 -8 8 2] -> [4 8 -8 -2]
// Console.Clear();
// int [] array = {-4, -8, 8, 2};
// int [] startarray = {-4, -8, 8, 2};

// ReversePosNeg(array);

// PrintArray(startarray);
// Console.Write(" -> ");
// PrintArray(array);
// // Logic ----------------------------------------------------------------------

// void PrintArray(int [] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++) //выводим наш массив
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");

// }

// void ReversePosNeg(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] *  (-1);
//     }
// }

//Задача 33. Задайте массив. ПРисутствует ли заданное число в массиве.  4; массив [ 5 7 13 4 5] -> нет


// Console.Write("Введите Х: ");
// int num = int.Parse(Console.ReadLine() ?? "");

// int [] array = {6, 4, 11 , 7, 145 ,1};

// PrintArray(array, num);
// Console.Write(" -> ");
// NumberIn(array, num);
// // Logic ----------------------------------------------------------------------

// void PrintArray(int [] array, int num)
// {
//     Console.Write($"{num}; массив [");
//     for (int i = 0; i < array.Length - 1; i++) //выводим наш массив
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");

// }

// void NumberIn(int [] array, int num) //метод нахождения вводимого числа в массиве
// {
//     for (int i = 0; i < array.Length; i++)
    
//         if (array[i] == num)
//         {
//             Console.Write("да");
//             break;
//         }
//         else
//         {
//             Console.Write("нет");
//             break;
//         }        
// }

