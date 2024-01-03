using System;

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public class IntArray : ISort
{
    private int[] elements;

    public IntArray(int[] arr)
    {
        elements = arr;
    }

    public void SortAsc()
    {
        Array.Sort(elements);
    }

    public void SortDesc()
    {
        Array.Sort(elements);
        Array.Reverse(elements);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }

    public void PrintArray()
    {
        Console.WriteLine(string.Join(", ", elements));
    }
}

class Program
{
    static void Main()
    {
        int[] myArray = { 5, 2, 8, 1, 7 };

        IntArray arrayInstance = new IntArray(myArray);

        Console.WriteLine("Оригинальный список:");
        arrayInstance.PrintArray();

        Console.WriteLine("\nСортировка по возрастанию:");
        arrayInstance.SortAsc();
        arrayInstance.PrintArray();

        Console.WriteLine("\nСортировка в порядке убывания:");
        arrayInstance.SortDesc();
        arrayInstance.PrintArray();

        Console.WriteLine("\nСортировка по параметру (по возрастанию):");
        arrayInstance.SortByParam(true);
        arrayInstance.PrintArray();

        Console.WriteLine("\nСортировка по параметру (по убыванию):");
        arrayInstance.SortByParam(false);
        arrayInstance.PrintArray();
    }
}
