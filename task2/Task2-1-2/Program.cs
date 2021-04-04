using System;
//my ass burning when im thinking about this task and why its not works
//so i decided to freeze this task until i finish task 3
//because i need to burn this project and begin from start
//I'll start it again later
namespace Task2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escape = false;
            var user = MakeUser();
            while (!escape)
            {
                PrintMenu(user.Name);
                int key;
                while (!int.TryParse(Console.ReadLine(), out key) && key < 6 && key > 0)
                {
                    Console.WriteLine("number should be in range [1,5], please enter a valid number");
                }
                switch (key)
                {
                    case 1:
                        FiguresManager(user);
                        break;

                    case 2:
                        ShowFigures(user);
                        break;

                    case 3:
                        user.ClearFigures();
                        break;

                    case 4:
                        user = MakeUser();
                        break;
                    case 5:
                        escape = true;
                        break;
                }
            }
        }
        static void FiguresManager(User user)
        {
            PrintFiguresMenu(user.Name);
            int key;
            while (!int.TryParse(Console.ReadLine(), out key) && key < 8 && key > 0)
            {
                Console.WriteLine($"{user.Name}, number should be in range [1,7], please enter a valid number");
            }
            double radius, outerRadius;
            Point p1, p2, p3, p4,center;
            Line l1, l2, l3, l4;
            switch (key)
            {
                case 1:
                    {
                        Console.WriteLine("Make Line");
                        p1 = MakePoint();
                        p2 = MakePoint();
                        while (p1.Equals(p2))
                        {
                            Console.WriteLine("Line cant starts and ends in 1 point, enter another point");
                            p2 = MakePoint();
                        }
                        user.AddFigure((Figure)new Line(p1, p2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Make Round");
                        MakeARoundBase(out center, out radius);
                        user.AddFigure(new Round(center, radius));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Make Cirlce");
                        MakeARoundBase(out center, out radius);
                        user.AddFigure(new Cirlce(center, radius));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Make Ring");
                        MakeARoundBase(out center, out radius);
                        Console.WriteLine("enter outer radius");
                        outerRadius = DoubleParser();
                        while (radius > outerRadius)
                        {
                            Console.WriteLine("Outer radius should be greater then inner, enter a valid radius:");
                            outerRadius = DoubleParser();
                        }
                        user.AddFigure(new Ring(center, radius, outerRadius));
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Make Square");
                        MakeRetangleBase(out l1, out l2, out l3, out l4);
                        if (Rectangle.IsValid(l1, l2, l3, l4) && l1.Length == l2.Length
                            && l2.Length == l3.Length && l3.Length == l4.Length)
                        {
                            user.AddFigure(new Rectangle(l1, l2, l3, l4));
                        }
                        else
                        {
                            Console.WriteLine("its not a square, try again");
                            MakeRetangleBase(out l1, out l2, out l3, out l4);
                        }
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Make Rectangle");
                        MakeRetangleBase(out l1, out l2, out l3, out l4);
                        if (Rectangle.IsValid(l1, l2, l3, l4))
                        {
                            user.AddFigure(new Rectangle(l1, l2, l3, l4));
                        }
                        else
                        {
                            Console.WriteLine("its not a rectangle, try again");
                            MakeRetangleBase(out l1, out l2, out l3, out l4);
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Make Triangle");
                        MakeTriangleBase(out l1, out l2, out l3);
                        while (!Triangle.IsValid(l1, l2, l3))
                        {
                            Console.WriteLine("its not a triangle");
                            MakeTriangleBase(out l1, out l2, out l3);
                        }
                        user.AddFigure(new Triangle(l1, l2, l3));
                        break;
                    }
            }
        }

        private static void MakeTriangleBase(out Line l1, out Line l2, out Line l3)
        {
            var p1 = MakePoint();
            var p2 = MakePoint();
            var p3 = MakePoint();
            l1 = new Line(p1, p2);
            l2 = new Line(p2, p3);
            l3 = new Line(p3, p1);
        }

        private static void MakeRetangleBase(out Line l1, out Line l2, out Line l3, out Line l4)
        {
            Console.WriteLine("enter first point");
            var p1 = MakePoint();
            Console.WriteLine("enter second point");
            var p2 = MakePoint();
            Console.WriteLine("enter third point");
            var p3 = MakePoint();
            Console.WriteLine("enter fourth point");
            var p4 = MakePoint();
            l1 = new Line(p1, p2);
            l2 = new Line(p2, p3);
            l3 = new Line(p3, p4);
            l4 = new Line(p4, p1);
        }

        private static void MakeARoundBase(out Point center, out double radius)
        {
            Console.WriteLine("Enter Center of Ring");
            center = MakePoint();
            Console.WriteLine("enter radius:");
            radius = DoubleParser();
            while (radius > 0)
            {
                Console.WriteLine("radius should be positive");
                radius = DoubleParser();
            }
        }

        private static Point MakePoint()
        {
            Console.WriteLine("enter X:");
            double x = DoubleParser();
            Console.WriteLine("enter Y:");
            double y = DoubleParser();
            return new Point(x, y);
        }

        private static double DoubleParser()
        {
            double num;
            while (double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter number in {21.4423} format:");
            }
            return num;
        }

        private static User MakeUser()
        {
            Console.Write("Hello! Please enter name:");
            var name = Console.ReadLine();
            while (name.Length <= 1 || name == string.Empty)
            {
                Console.WriteLine("enter a real name please:");
                name = Console.ReadLine();
            }
            return new User(name); ;
        }

        static void PrintMenu(string name)
        {
            var n = Environment.NewLine;
            Console.WriteLine($"{name}, choose action:{n}"+
                $"\t 1. Add Figure{n}\t 2. Show Figures{n}\t 3. Clear Page{n}\t 4.Change user{n}"+
                $"\t 5. Exit{n}Enter a number:");
        }

        static void PrintFiguresMenu(string name)
        {
            var n = Environment.NewLine;
            Console.WriteLine($"{name}, choose the figure:{n}\t 1. Line{n}\t 2. Round{n}\t 3. Circle{n}\t 4. Ring{n}"
                +$"\t 5. Square{n}\t 6. Rectangle{n}\t 7. Triangle{n}Enter a number:");
        }

        static void ShowFigures(User user)
        {
            Console.WriteLine();
            Console.WriteLine($"{user.Name} figures:");
            foreach (var item in user.Figures)
            {
                switch (item.Type)
                {
                    case FigureType.Line:
                        Console.WriteLine("Line" + ((Line)item).ToString());
                        break;

                    case FigureType.Round:
                        Console.WriteLine("Round" + ((Round)item).ToString());
                        break;

                    case FigureType.Circle:
                        Console.WriteLine("Circle" + ((Cirlce)item).ToString());
                        break;

                    case FigureType.Ring:
                        Console.WriteLine("Circle" + ((Ring)item).ToString());
                        break;

                    case FigureType.Rectangle:
                        if (((Rectangle)item).SubType == FigureType.Square)
                        {
                            Console.WriteLine("Square"+((Rectangle)item).ToString());
                        }
                        else Console.WriteLine("Rectangle"+((Rectangle)item).ToString());
                        break;

                    case FigureType.Triangle:
                        Console.WriteLine("Triangle"+((Triangle)item).ToString());
                        break;
                }
            }
        }
    }
}
