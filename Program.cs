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