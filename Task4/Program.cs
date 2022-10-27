// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число");
int num = Int32.Parse(Console.ReadLine());
while(num>2){
    if (num%2==0){
        Console.Write(num + ", ");
    }
   num--;
}
if(num==2){
    Console.Write(num);
}
else{
    Console.Write("Нет четных чисел");
}