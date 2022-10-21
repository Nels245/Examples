Console.Clear(); //очистка консоли
// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); //Вызов метода

// Вид 2 Ничего не возвращают, но могут принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); //Вызов метода

// Вид 2_1 может принимать несколько аргументов
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент - увеличение
    }
}
Method2_1(msg: "Текст", count: 4); //вывод текст count раз
Method2_1(count: 4, msg: "Новый текст" ); 

// Вид 3. Что-то возвращают но ничего не принимают
int Method3()
{
    return DateTime.Now.Year; // произошла работа
}
int year = Method3(); //сюда положен результат работы метода
Console.WriteLine(year);

//Вид 4. Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // пустая строка (String.Empty)
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf"); //выводим asdf 10 раз
Console.WriteLine(res);




