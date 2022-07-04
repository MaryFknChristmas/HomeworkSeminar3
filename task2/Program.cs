Console.WriteLine("Введите координату ax");
int AX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату ay");
int AY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату az");
int AZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату bx");
int BX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату by");
int BY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату bz");
int BZ = Convert.ToInt32(Console.ReadLine());

int distance = (BX - AX)*(BX - AX) + (AY - BY)*(AY - BY) + (BZ - AZ)*(BZ - AZ);

Console.WriteLine(Math.Sqrt(distance));