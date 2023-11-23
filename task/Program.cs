

#region task1
//Console.WriteLine("4 reqemli ededi daxil edin");
//int num = int.Parse(Console.ReadLine());
//string result = num.ToString();
//while (true)
//{
//    if (result.Length == 4)
//    {
//        Console.WriteLine("7" + result + "8");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Dogru ededi daxil et.....");
//        result = Console.ReadLine();
//    }
//}
#endregion

#region task 2
//Console.WriteLine("3 reqemli ededi daxil et");
//int num1 = int.Parse(Console.ReadLine());
//string result = num1.ToString();
//while (true)
//{
//    if (result.Length == 3)
//    {
//        Console.WriteLine(result + result);
//        break;
//    }
//    else 
//    {
//        Console.WriteLine("Dogru ededi daxil et.....");
//        result = Console.ReadLine();
//    }
//}
#endregion

#region task3
//Console.WriteLine("5 reqemli ededi daxil edin..");
//int num =int.Parse(Console.ReadLine());
//string result=num.ToString();
//while (true)
//{
//    if (result.Length == 5)
//    {
//        double outcome = ((num * 18) / 100);
//        double outcome2 = ((outcome * 3) / 100);
//        Console.WriteLine(outcome2);
//        break;
//    }
//    else
//    {
//        Console.WriteLine("dogru ededi daxil edin..");
//        result = Console.ReadLine();
//    }

//}
#endregion


#region
Console.WriteLine("3 reqemli ededi daxil edin");
int num = int.Parse(Console.ReadLine());
string result4 = num.ToString();
while (true)
{
    if (result4.Length == 3)
    {
        int outcome = ((num * 1000) + 7);
        double outcome2 = ((outcome * 7) / 100);
        Console.WriteLine(outcome2);
        break;
    }
    else
    {
        Console.WriteLine("Dogru ededi daxil edin");
        result4 = Console.ReadLine();
    }
}
#endregion



#region
Console.WriteLine("4 reqemli ededi daxil edin");
int num5 = int.Parse(Console.ReadLine());
string result5 = num5.ToString();
while (true)
{
    if (result5.Length == 4)
    {
        string result6 = "4" + result5 + "44";
        int outCome = int.Parse(result6);
        double lastResult = ((outCome * 44) / 100);
        Console.WriteLine(lastResult);
        break;
    }
    else
    {
        Console.WriteLine("Dogru ededi daxil edin");
        result5 = Console.ReadLine();
    }
}
#endregion


#region
Console.WriteLine("4 reqemli ededi daxil edin");
int num6 = int.Parse(Console.ReadLine());
string result6 = num6.ToString();
while (true)
{
    if (result6.Length == 4)
    {
        double outcome = ((num6 * 20) / 100);
        double outcome2 = ((outcome * 10) / 100);
        double outcome3 = outcome2 * outcome2;
        Console.WriteLine(outcome3);
        break;
    }
    else
    {
        Console.WriteLine("Dogru ededi daxil edin");
        result6 = Console.ReadLine();
    }
}
#endregion

#region //bu alinmadi tezden bax
Console.WriteLine("1 ci ededi daxil et");
int num1 = int.Parse(Console.ReadLine());
string result1 = num1.ToString();
Console.WriteLine("2 ci ededi daxil et");
int num2 = int.Parse(Console.ReadLine());
string result2 = num2.ToString();

while (true)
{
    if (result1.Length == 5 && result2.Length == 5)
    {
        int outcome1 = num1 + num2;
        string result3 = outcome1.ToString();
        Console.WriteLine("5" + outcome1 + "5");
        int outcome2 = int.Parse(result3);
        double outcome3 = ((outcome2 * 10) / 100);
        Console.WriteLine(outcome3);
        break;
    }
    else
    {
        Console.WriteLine("Dogru ededi daxil edin.......");
        result1 = Console.ReadLine();
        result2 = Console.ReadLine();

    }
}
#endregion

