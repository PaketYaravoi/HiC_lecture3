Console.WriteLine("Method1, a method that accepts nothing and returns nothing: ");

void Method1()
{
    Console.WriteLine("Groshkov R");
}

Method1();
Console.WriteLine();


Console.WriteLine("Method2, a method that takes argements but returns nothing: ");

void Method2(string usName = "R_Groshkov")
{
    Console.WriteLine(usName); // дополнительная переменная в которую можно присвоить любую строку
}

void Method2_1(string msg, int count) // тот же метод но с добовлением еще одной переменной. 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2();                     // отработка с переменной по умолчаюнию
Method2("GroshkovTheBest");    // отработка с изменениеиенм данных string usName при вызове метода.
Method2_1(count: 3, msg: "Any Text !!!"); // вызов метода с четким указаниме условия выполнения тела метода.
Console.WriteLine();


Console.WriteLine("Method3,These are methods that return something but do not accept anything: ");

int method3()
{
    return DateTime.Now.Year;  // командой return возвращаем значение
}

int year = method3();    // присваиваем результат метода в переменную
Console.WriteLine(year); // печаиаем перузультат
Console.WriteLine();


Console.WriteLine("Method4, this is a method that accepts and returns values: ");

//string Metod4(int count, string text)
//{
//    int i = 0;                             // переменная для цикла
//    string result = String.Empty;          // переменная для хранения , по умолчанию пустая   String.Empty
//    while (i < count)
//    {
//        result = result + "/" + text ;      // перепись значения каждую итерацию 
//        i++;
//    }
//    return result;                         // возвращение конечного результата
//}
//string res = Metod4(10, "ААА");           // создали новую переменную вне метода, под хранение результатов выполнения метода 
//Console.WriteLine(res);                    
//Console.WriteLine();

string Method4(int count , string text) // Тот же метод только цикл for!
{
    string resolt = String.Empty;
    for (int i = 0; i < count; i++)
    { 
        resolt = resolt + text;
    }
    return resolt;
}

string resolt = Method4(4, "php");
Console.WriteLine(resolt);
Console.WriteLine();


Console.WriteLine("multiplication table:");

for (int i = 2; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}