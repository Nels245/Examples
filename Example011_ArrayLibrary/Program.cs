//Заполнение массива рандомными числами

    void FillArray(int[] collection)
        {
            int length =collection.Length;
            int index = 0;
            while (index < length)
            {
                collection[index] = new Random().Next(1,10);
                index++;
            }
        }

// Функция вывода массива
      
    void PrintArray(int[] col)
        {
            int count = col.Length;
            int position = 0;
            while (position <count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
        }
        
// Фукнция первого вхождения искомого индекса

    int IndexOf(int[] collection, int find)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1; // Задаем позицию -1, т.к если нужного елемента не будет в массиве он вывел -
        while (index < count)
        {
            if(collection[index] == find)
            {
                position = index;
                break;
            }
            index++;
        }
        return position;
    }
        
    int [] array = new int[10];
    
    FillArray(array); // Заполнение массива
    PrintArray(array); // Вывод массива в консоль
    Console.WriteLine(); // Обычный отступ)
    
    int pos = IndexOf(array, 4); // Поиск первого вхождения элемента 4 в массиве array
    Console.WriteLine(pos);
