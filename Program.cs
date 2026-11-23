using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2);
        Circle circle = new Circle(3);

        List<Figure> figures = new List<Figure> {square, circle};

        foreach (Figure fig in figures)
        {
            fig.Draw();
        }
    }
}


class Figure
{
    int Size;

    public virtual void Draw()
    {
        Console.WriteLine("figure");
    }

    public Figure(int size)
    {
        Size = size;
    }
}

class Square : Figure
{
    public override void Draw()
    {
        Console.WriteLine("🟩");
    }

    public Square(int size) : base (size)
    {
        
    }
}

class Circle : Figure
{
    public Circle (int size) : base (size)
    {
        
    }

    public override void Draw()
    {
        Console.WriteLine("🟢");
    }
}