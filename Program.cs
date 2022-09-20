string ReadData()
{
    Console.WriteLine("Введите элементы массива");
    return Console.ReadLine()??"";
}


void PrintArray(string [] inputArray)
{
    Console.Write("[");
    for(int i=0;i<inputArray.Length-1;i++)
    {
        if(inputArray[i]!="")
        {
            if(i==0) Console.Write(inputArray[i]);
            else{Console.Write(","+ inputArray[i]);}
        }
    }
    Console.Write("]");
}
string inputString=ReadData();
Console.WriteLine(inputString);
//пример строки ["hello", "2", "world", ":-)"]
string inputStringFilter = inputString.Replace("[", "").Replace("]", "");
Console.WriteLine(inputStringFilter);
string [] inputArray=inputStringFilter.Split(", ");
PrintArray(inputArray);