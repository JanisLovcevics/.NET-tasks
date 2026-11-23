class BoxTester
{
    static void Main(string[] args)
    {
        Box box = new Box(2.5, 5.0, 6.0);

        Console.WriteLine($"Area: {box.area()}  volume: {box.volume()}");
        Console.WriteLine($"length: {box.Length()} height: {box.Height()} width: {box.Width()}");
        Console.WriteLine($"Nests: {box.nests(new Box(3.0, 5.1, 7.0))}");
    }
}

class Box
{
    private double width;
    private double height;
    private double length;
    private double size;

    public Box (double width, double height, double length)
    {
        this.width = width;
        this.height = height;
        this.length = length;
    }

    public Box (double size)
    {
        this.size = size;
    }

    public Box (Box oldBox)
    {
        width = oldBox.width;
        height = oldBox.height;
        length = oldBox.length;
        size = oldBox.size;
    }

    public double volume()
    {
        return width * height * length;
    }

    double faceArea()
    {
        return width * height;
    }

    double topArea()
    {
        return width * length;
    }

    double sideArea()
    {
        return length * height;
    }

    public double area()
    {
        return 2 * faceArea() + 2 * topArea() + 2 * sideArea();
    }

    public double Length()
    {
        return length;
    }

    public double Height()
    {
        return height;
    }

    public double Width()
    {
        return width;
    }

    public Box biggerBox (Box oldBox)
    {
        return new Box(1.25*oldBox.width, 1.25*oldBox.height, 1.25*oldBox.length);
    }

    public Box smallerBox (Box oldBox)
    {
        return new Box(0.75*oldBox.width, 0.75*oldBox.height, 0.75*oldBox.length);
    }

    public bool nests (Box outsideBox)
    {
        return length < outsideBox.length && width < outsideBox.width && height < outsideBox.height;
    }
}