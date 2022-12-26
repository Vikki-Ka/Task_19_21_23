/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
int getUserValue(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

double distans(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    dist = Math.Round(dist, 2);
    return dist;
}

int x1 = getUserValue("Ввидите координату x первой точки ");
int y1 = getUserValue("Ввидите координату y первой точки ");
int z1 = getUserValue("Ввидите координату z первой точки ");
int x2 = getUserValue("Ввидите координату x второй точки ");
int y2 = getUserValue("Ввидите координату y второй точки ");
int z2 = getUserValue("Ввидите координату z второй точки ");

double rast = distans(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {rast}");