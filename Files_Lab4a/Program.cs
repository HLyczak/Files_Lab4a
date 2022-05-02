using System;

namespace Files_Lab4a
{
    // Do zaimplementowania zadania zdecydowałam się na użycie kolejki oraz słownika z value w postaci propeties.
    // Dzięki kolejce katalog skanowany jest jednoktornie, dzięki czemu uzyskujemy złożoność obliczeniową algorytmu na poziomie O(n).
    // Do wyśweitlania użylam dictionary, ponieważ pomogło mi to w uzykskaniu łatwego dostępu do danych.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Class1.Search(@"C:\Users\Honorata.Lyczak");
        }
    }
}