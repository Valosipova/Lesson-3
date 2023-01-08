//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> дa

int Prompt(string massage)
{
	Console.Write(massage);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int Reverse(int number) 
{ 
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number = number / 10;
    }
return reverse;
}
bool Palindrome(int number)
{
    return number == Reverse(number);
}
int number = Prompt("Введите число: ");
if (Palindrome(number))
{
    Console.WriteLine ($"Число: {number} является палиндромом");
}
else
{
    Console.WriteLine ($"Число: {number} не является палиндромом");
}
