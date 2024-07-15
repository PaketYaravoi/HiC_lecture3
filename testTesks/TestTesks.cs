//=====                                                                       Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача? Всегда уточнять ТЗ!!!


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
     + "ежели бы вас послали вместо нашего милого Винценгероде,"
     + "вы бы взяли приступом согласие прусского короля."
     + "Вы так красноречивы. Вы дадите мне чаю?";

// Для начала нужно понять следующее , строка это массив данных!
//а значит к любому символу мы можем обратиться по его индексу , таким образом если:
//    string s = "qwerty"
//                0123
//    s[3] - это бука "r" 

//    Зная это будем приступать к написаю кода!

string Replace(string inputText, char oldValue, char newValue)
{ 
    string resolt = String.Empty;
    int length = inputText.Length;
    for (int i = 0; i < length; i++)
    {
        if (inputText[i] == oldValue)
        {
            resolt += $"{newValue}";
        }
        else
        {
            resolt += $"{inputText[i]}";
        }
        
    }
    return resolt;
    
}

string nowText = Replace(text, ' ', '-');
nowText = Replace(nowText, 'к' , 'К');
nowText = Replace(nowText, 'с', 'С');
Console.WriteLine(nowText);