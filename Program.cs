string ReadData()
{
    Console.WriteLine("Введите элементы массива");
    return Console.ReadLine()??"";
}

string inputString=ReadData();
Console.WriteLine(inputString);