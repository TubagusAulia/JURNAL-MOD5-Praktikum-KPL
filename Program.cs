using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class SimpleDataBase <T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() 
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData ()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi {storedData[i].ToString()}, yang disimpan pada waktu {inputDates[i].ToString()}");
        }
    }
}

class Program
{
    private static void Main ()
    {
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(20);
        data.PrintAllData();
    }
}