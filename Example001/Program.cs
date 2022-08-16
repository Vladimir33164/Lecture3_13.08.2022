// М    Е   Т   О   Д   Ы.

// ПЕРВАЯ группа методов.

//Это методы, которые ничего не возвращают и ничего не принимают.

//void Method1()
//{
    //Console.WriteLine("Автор...");
//}

// Как вызываются подобного рода методы:

//Method1(); правильный вызов метода
//Method1;     False

//ВТОРАЯ группа методов.

//Это методы, которые ничего не возвращают, но принимают какие-то аргументы.

/*void Method2(string msg) //void - ключевое слово, Method - идентификатор, msg - количество элементов.
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/

//Встречаются ещё и именованные аргументы.

//void Method21(string msg, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//        инкремент; (--) декремент.
//    }
//}

//Method21(count: 4, msg: "новый текст");


//ТРЕТЬЯ группа методов

//Что-то возвращают, но ничего не принимают.
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

// Ч    Е   Т   В   Ё   Р   Т   А   Я   группа методов.

//Что-то принимают и что-то возвращают

string Method4(int count, string c) //Что за новая переменная char? Почему её заменили на string?
{
    int i = 0;
    string result = string.Empty; //String.Emrty - пустая строка.
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);