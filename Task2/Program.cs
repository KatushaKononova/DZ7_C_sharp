// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите три целочисленных числа в консоль");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

if(Int32.Parse(num1)>Int32.Parse(num2)){
    if(Int32.Parse(num1)>Int32.Parse(num3)){
        Console.WriteLine("Большее число: "+ num1);
    }
    else{
        Console.WriteLine("Большее число: "+ num3);
    }
}
else
{
    if(Int32.Parse(num2)>Int32.Parse(num3)){
        Console.WriteLine("Большее число: "+ num2);
    }
    else{
        Console.WriteLine("Большее число: "+ num3);
    }
}