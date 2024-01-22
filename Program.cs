string[] startArray = { "Hello", "my", "teacher", "!", ":-)" };
PrintArray(startArray);
string [] resultArray = CalculateArray(startArray);

void PrintArray(string[] arr)
{
    string str = "[" + String.Join(", ", arr) + "]";
    Console.WriteLine(str);
}
string[] CalculateArray(string[] arr)
{
    string[] resultArray = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Array.Resize(ref resultArray, resultArray.Length +1 );
            resultArray [resultArray.Length-1] = arr [i];
        }
    }
    return resultArray;
}
