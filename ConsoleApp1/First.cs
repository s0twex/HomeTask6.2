using System;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double x);

class First
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static double Sinus(double x, double a)
    {
        return a * Math.Sin(x);
    }

    public static void Table(fun1 F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }

        
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x)
    {
        return x * x * x;
    }

    static void Main()
    {
        Console.WriteLine("Таблица функции MyFunc1:");
        Table(new fun1(MyFunc1), -2, 2);
        Console.WriteLine("Таблица функции MyFunc2:");
        Table(new fun1(MyFunc2), -2, 2);

    }


    public delegate double fun1(double a, double x);
    public static double MyFunc1 (double a, double x)
    {
        return a * x * x;
    }

    public static double MyFunc2(double a, double x)
    {
        return a * Math.Sin(x);
    }


}

