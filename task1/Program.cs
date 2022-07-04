Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
Task1(number);
void Task1(string currentNumber)
{
    if (currentNumber[0] == currentNumber[4] && currentNumber[1] == currentNumber[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}