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
using System;

class PemrosesData
{
    public static void DapatkanNilaiTerbesar<T>(T parameter1, T parameter2, T parameter3) where T : IComparable
    {
        dynamic Max = parameter1;

        if (parameter2.CompareTo(Max) > 0) Max = parameter2;
        if (parameter3.CompareTo(Max) > 0) Max = parameter3;

        Console.WriteLine($"Nilai terbesar adalah : {Max}");
    }
}

class Prorgam
{
    static void Main()
    {
        float nim1 = 10;
        float nim2 = 30;
        float nim3 = 22;

        PemrosesData.DapatkanNilaiTerbesar( nim1, nim2, nim3 );
    }
}