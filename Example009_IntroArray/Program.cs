
//              0   1   2  3  4 5 6  7 8  - индексы массива
int[] array = {133,211,32,43,54,6,72,43,91};

int n = array.Length; // длина массива
int find = 43;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //поиск только первого элемента, там два элемента со значением 43
    }
    //index = index + 1
    index++;
}
