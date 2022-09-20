string ReadData()
{
    Console.WriteLine("Введите элементы массива");
    return Console.ReadLine()??"";
}

string [] ArrayFiltering(string [] inputArray)
{
    string [] outArray = new string[inputArray.Length];
    int j=0;
    int countElements=5;//3элемента + "" = 5 элементов
    for(int i=0;i<inputArray.Length; i++)
    {
        if(inputArray[i].Length<=countElements)//
        {
            outArray[j]=inputArray[i];
            j++;
        }
    }
    return outArray; 
}

void PrintArray(string [] inputArray)
{
    Console.Write("[");
    for(int i=0;i<inputArray.Length-1;i++)
    {
        if(inputArray[i]!=null)
        {
            if(i==0) Console.Write(inputArray[i]);
            else{Console.Write(","+ inputArray[i]);}
        }
    }
    Console.Write("]");
}
string inputString=ReadData();
//пример строки ["hello", "2", "world", ":-)"]
string [] inputArray=inputString.Replace("[", "").Replace("]", "").Split(", ");//исключаем [], разделяем на подстроки по ,
string [] resultArray=ArrayFiltering(inputArray);
PrintArray(resultArray);