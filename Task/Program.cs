// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] Array = {"hello", "2", "world", ":-)"}; 
string[] sortArray = new string[Array.Length]; 

void SortArray(string[] arr, string[] sortArr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            sortArr[count] = arr[i];
            count++;
        }
    }
}
void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}