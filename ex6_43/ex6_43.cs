/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Coord crossCoord = new Coord();
        Console.WriteLine("Введите параметры прямой 1:");
        LineParam line1 = GetLineParam();
        Console.WriteLine("Введите параметры прямой 2:");
        LineParam line2 = GetLineParam();
        if (FindLineCrossPoint(line1, line2, out crossCoord))
        {
            Console.WriteLine($"Прямые пересекутся в точке ( {crossCoord.x} {crossCoord.y} )");
        }
        else
        {
            Console.WriteLine("Прямые не пересекутся");
        }

        LineParam GetLineParam()
        {
            LineParam line = new LineParam();
            Console.WriteLine("Введите K:");
            line.k = InputFloatTryParse();
            Console.WriteLine("Введите B:");
            line.b = InputFloatTryParse();
            return line;
        }

        static float InputFloatTryParse()
        {
            while (true)
            {
                float val;
                if (float.TryParse(Console.ReadLine(), out val))
                    return val;
                else
                    Console.WriteLine("Ошибка ввода! Введите еще раз: ");
            }
        }

        bool FindLineCrossPoint(LineParam line1, LineParam line2, out Coord cross)
        {
            if ((line1.k - line2.k) == 0)
            {
                cross.x = cross.y = 0;
                return false;
            }
            cross.x = (line2.b - line1.b) / (line1.k - line2.k);
            cross.y = cross.x * line1.k + line1.b;
            return true;
        }
    }
    struct LineParam
    {
        public float k;
        public float b;
    }
    struct Coord
    {
        public float x;
        public float y;
    }
}