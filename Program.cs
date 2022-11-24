System.Console.Clear();
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
string[] ToFillArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        string input_text = "элемент массива";
        array[i] = ToInputVar(input_text);
    }
    return array;
}
string[] ToPrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}-й: \"{array[i]}\";");
    }
    return array;
}
string[] ToMakeNewArrayFromOldArrayWithCondition(string[] array,int condition)
{
    string[] new_array = new string[array.Length];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i].Length<=condition)
        {
            new_array[j]=array[i];
            j++;
        }
    }
    Array.Resize(ref new_array,j);
    return new_array;
}

string input_text = "количество элементов массива";
int n = int.Parse(ToInputVar(input_text));
string[] array = ToFillArray(n);
int condition=3;
string[] new_array=ToMakeNewArrayFromOldArrayWithCondition(array,condition);
ToPrintArray(new_array);