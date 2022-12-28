string[] strArray = {"Hello", "2", "world", ":-)"};
string[] newStrArray = new string[strArray.Length];
void ModifiedStringArray(string[] strArray, string[] newStrArray)
{
    int count = 0;
    for(int i = 0; i < strArray.Length; i++)
    {
        if(strArray[i].Length <= 3)
        {
            newStrArray[count] = strArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for(int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
