//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x = 0;
int y = 1;
int z = 2;

int Prompt(string massage)
{
	Console.Write(massage);
	int number = int.Parse(Console.ReadLine()!);
	return number;
}

int[] InputPoint (int point)
{
	int[] answer = new int[3];
	answer[x] = Prompt($"Введите x: {point} - ");
	answer[y] = Prompt($"Введите y: {point} - ");
	answer[z] = Prompt($"Введите z: {point} - ");
	return answer;
}

double SquareNumber(int arg) 
{
	return Math.Pow(arg, 2);
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(SquareNumber(p1[x] - p2[x]) + SquareNumber(p1[y] - p2[y]) + SquareNumber(p1[z] - p2[z]));

Console.WriteLine($"{lenght:f2}");