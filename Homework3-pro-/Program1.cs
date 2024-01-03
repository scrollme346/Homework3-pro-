using System;
using System.Linq;


interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

class MyArray : IMath
{
    private int[] array;

    public MyArray(int[] arr)
    {
        array = arr;
    }

    public int Max() => array.Max();

    public int Min() => array.Min();

    public float Avg() => (float)array.Average();

    public bool Search(int valueToSearch) => array.Contains(valueToSearch);
}
class Program
{
    static void Main()
    {
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        MyArray myArrayObj = new MyArray(myIntArray);


        Console.WriteLine($"Максимум: {myArrayObj.Max()}");
        Console.WriteLine($"Минимум: {myArrayObj.Min()}");
        Console.WriteLine($"Среднее орифметическое: {myArrayObj.Avg()}");
        Console.WriteLine($"Поиск числа 3: {myArrayObj.Search(3)}");
        Console.WriteLine($"Поиск числа 8: {myArrayObj.Search(8)}");
    }
}
