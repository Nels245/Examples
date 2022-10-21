// Лекция 4. Двумерные массивы и рекурсия
string[,] table = new string[2,5];// 2строки и 5 столбцов
//String.Empty - инициализация констатой
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,5]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,5]

// table[1,2] = "слово";

// for ( int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

//Выводим массив чисел
//Logic --------------------------------
// void PrintArray(int[,] matr) //в качестве аргумента принимает двумерную таблицу чисел
// //и будет печатать ее на экран
// {
//     for(int i= 0; i < matr.GetLength(0); i++)
//     {
//         for ( int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//     Console.WriteLine();    //делаем матрицу
//     }
// }

// void FillArray(int[,] matr)
// {
//     for ( int i = 0; i < matr.GetLength(0);i++)
//     {
//         for ( int j = 0; j < matr.GetLength(1);j++)
//         {
//             matr[i,j] = new Random().Next(1,10);//[1;10]
//         }
//     }
// }
// //Initialization ----------------------
// int[,] matrix = new int[3,4];
// PrintArray(matrix);//выводим массив из нулей
// FillArray(matrix);//заполняем массив рандомными числами
// Console.Write();
// PrintArray(matrix);//выводим массив заполненый ранд числами

//Рисуем картинку и заполняем её внутренности

// int [,] pic = new int [,]
// {
//     {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0},
// };

// //Logic ----------------------------------------------
// void PrintImage(int[,] image)
// {
//     for(int i= 0; i < image.GetLength(0); i++)
//     {
//         for ( int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write("+");
//         }
//     Console.WriteLine();    //делаем матрицу
//     }
// }

// void FillImage(int row, int col) //принмает координаты точки с которой начинет закраску
// {
//     if(pic[row, col] == 0) //пиксель не закрашен
//     {
//         pic[row, col] = 1;
//         FillImage(row-1,col);
//         FillImage(row,col-1);
//         FillImage(row+1,col);
//         FillImage(row,col+1); //идем вправо оставаясь в той же строке
//     }
// }

// //Inicialization ------------------------------------------------------

// PrintImage(pic);
// FillImage(5,10);
// PrintImage(pic);

//Рекурсия. Метод возвращающий факториал себя

// int Factorial (int n)
// {
//     // 0! =1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine(Factorial(i)); // 1*2*3 =6
// }

//Рекурсия. Числа фиббоначи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(double n)
// {
//     if(n == 1 || n ==2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }