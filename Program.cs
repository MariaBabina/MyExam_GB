string[] startArray = { "Hello", "my", "teacher", "!", ":-)" };
PrintArray(startArray);


void PrintArray(string[] arr)
{
    string str = "[" + String.Join(", ", arr) + "]";
    Console.WriteLine(str);
}
