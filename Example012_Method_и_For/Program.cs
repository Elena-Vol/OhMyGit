// Метод ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор .......");
}
Method1(); 








// Метод что-то принимает и ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++; // инкримент, уменьшение - декримент
    }
}
Method21(count: 4, msg: "Повторение текста сообщения"); // явное указание какому аргументу что присвоить (уже не важна последовательность)








// Метод ничего не принимает и что-то возвращает
int Method3()
{
    return DateTime.Now.Year;       
}
int year = Method3();
Console.WriteLine($"Текущий год - {year}");






// Метод что-то не принимает и что-то возвращает
/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;      //result = ""; - обознание пустой строки
    while (i < count)
    {    
        result = result + text;
        i ++;
    }
    return result;
}
string res = Method4(10,  "vav ");  
Console.WriteLine(res); */



// Цикл FOR для МУТОД 4 
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;      //result = ""; - обознание пустой строки
    for (i = 0; i < count; i ++)
    {    
        result = result + text;
    }
    return result;
}
string res = Method4(10,  "vav ");  
Console.WriteLine(res);

