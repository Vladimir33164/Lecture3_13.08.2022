//                          Ц   И   К   Л   for

//Возмём решение предыдущего (последнего) примера.

/*
string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0, i < count, i++)
    Порядок действий: инициализация счётчика (int i = 0);
    проверка условия (i < count);
    и инкремент (i++), т.е. > счётчика.
    while () - убираем while из кода.
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

//95-99 % задач решаются при помощи цикла for, а также циклом while.

//А также мы можем использовать цикл внутри цикла.
//Рассмотрим цикл на примере таблицы умножения:

for (int i = 2, i <= 10, i++)
{
    for (int j = 2, j <= 10, j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}


//Следующая задача:
//Условие задачи: Дан текст. В тексте нужно все 
//пробелы заменить черточками, маленькие буквы 
//“к” заменить большими “К”, а большие “С” 
//заменить маленькими “с”.

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int Lenght = text.Length;
    for(int i = 0; i < Lenght; i++)
    {
        if(text[i] == oldValue) result = $"{newValue}";
        else result = $"{text[i]}";
    }

    return result;
}
string newText = Replace(text; '', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');
Console.WriteLine();
*/
