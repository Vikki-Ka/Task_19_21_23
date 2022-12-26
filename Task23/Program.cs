/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void kub(int number)
{
    for (int i = 1; i <= number; i++ )
    {
        double kub = Math.Pow(i, 3);
        if (i < number)
        {
            Console.Write($"{kub}, ");
        }
        else
        {
            Console.Write($"{kub} ");
        }
    }

}
int n = getUserValue("Ввидите число ");
kub(n);