// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите 2 целочисленных числа");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
if(Int32.Parse(num1)>Int32.Parse(num2)){
    Console.WriteLine("Большее число: "+ num1 + ", меньшее: " + num2);
}
else
{
    Console.WriteLine("Большее число: "+ num2 + ", меньшее: " + num1);
}