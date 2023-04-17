using System;

class Circle
{
    private double x, y, r;

    public Circle(double x, double y, double r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public bool Intersects(Circle other_circle)
    {
        /* Проверяет, пересекаются ли текущая окружность и другая окружность */
        double distance_centers = Math.Sqrt(Math.Pow(this.x - other_circle.x, 2) + Math.Pow(this.y - other_circle.y, 2));
        return distance_centers < this.r + other_circle.r;
    }

    public double Circumference()
    {
        /* Вычисляет длину окружности */
        return 2 * Math.PI * this.r;
    }

    public bool Contains(double x, double y)
    {
        /* Проверяет, принадлежит ли точка (x,y) текущей окружности */
        double distance_center_point = Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        return distance_center_point <= this.r;
    }


}

class Program
{
    static void Main(string[] args)
    {
        // Инициализация объектов
        Circle circle1 = new Circle(0, 0, 5);
        Circle circle2 = new Circle(8, 0, 3);

        // Проверка пересечения окружностей
        bool intersects = circle1.Intersects(circle2);
        if (intersects)
        {
            Console.WriteLine("Окружности пересекаются.");
        }
        else
        {
            Console.WriteLine("Окружности не пересекаются.");
        }

        // Вычисление длины окружности
        double circumference = circle1.Circumference();
        Console.WriteLine("Длина окружности равна " + circumference);

        // Проверка принадлежности точки окружности
        bool contains_point = circle1.Contains(3, 4);
        if (contains_point)
        {
            Console.WriteLine("Точка (3, 4) принадлежит окружности.");
        }
        else
        {
            Console.WriteLine("Точка (3, 4) не принадлежит окружности.");
        }
    }
}
