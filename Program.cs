// See https://aka.ms/new-console-template for more information

using System;

namespace vscode
{
class Program
{

public static void Main()
{

    Console.WriteLine("Hello, World!");
    Console.WriteLine("kilonuzu giriniz");

        //kilo testi


    
        int kilo = int.Parse(Console.ReadLine());
        if (kilo <= 60)
            Console.WriteLine("ideal kilo");
        if (kilo >= 61 && kilo < 80)
            Console.WriteLine("kilo vermeniz gerek");
        else
            Console.WriteLine("obezite sınırı dikkat edin");

        string sonuc = kilo <= 60 ? "ideal kilo" : (kilo>=61 && kilo<80 ? "kilo vermeniz gerekli" : "obezite sınırı dikkat edin");
        Console.WriteLine(sonuc);
}   

}

}



