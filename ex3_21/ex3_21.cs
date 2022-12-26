/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Coord3d input3dPoint(){
   Coord3d point; 
    Console.WriteLine("X:");
    point.x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y:");
    point.y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z:");
    point.z = Convert.ToInt32(Console.ReadLine());
    return point;
}

double len2point3d(Coord3d p1, Coord3d p2)
{
    return Math.Sqrt(
        (p1.x-p2.x)*(p1.x-p2.x) +
        (p1.y-p2.y)*(p1.y-p2.y) +
        (p1.z-p2.z)*(p1.z-p2.z));
}

Coord3d point1;
Coord3d point2;

Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
point1 = input3dPoint();
Console.WriteLine("Введите координаты второй точки:");
point2 = input3dPoint();
double len = len2point3d(point1, point2);

Console.WriteLine($"Расстояние между точками = {len,0:F2}");

struct Coord3d{
    public int x;
    public int y;
    public int z;
}
