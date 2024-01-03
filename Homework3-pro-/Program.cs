using System;

interface IOutput
{
    void Show();
    void Show(string info);
}
class MyArray : IOutput
{
    private int[] array;

    public MyArray(int[] arr)
    {
        array = arr;
    }

    public void Show()
    {
        Console.WriteLine("Елементы масива");
        foreach (var element in array)
        {
            Console.WriteLine(element + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine("Элементы масива:");
        foreach(var element in array)
        {
            Console.WriteLine(element + " ");
        }
        Console.WriteLine($"\nИнформация: {info}");
    }

}

class Program
{
    static void Main()
    {
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        MyArray myArrayObj = new MyArray(myIntArray);

        myArrayObj.Show();
        myArrayObj.Show("Тестовое сообщение");

    }
}