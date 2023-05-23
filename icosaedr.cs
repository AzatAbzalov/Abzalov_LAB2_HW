class icosaedr
{
    private string title;
    private double edge;
    public string Title
    {
        get => title;
        set => title = value;
    }
    public double Edge
    {
        get { return edge; }
        private set
        {
            while (value <= 0)
            {
                Console.WriteLine("Ребро должно быть положительным ");
                value = InpEdge();
            }
            edge = value;
        }
    }
    public icosaedr()
    {
        Edge = InpEdge();
        Title = InpTitle();
        Console.WriteLine();
    }
    public icosaedr(double edge = 1.0, string title = " ")
    {
        Edge = edge;
        Title = title;
        if (title == " ") Title = InpTitle();
    }
    public string InpTitle()
    {
        Console.Write("Введите подпись фигуры: ");
        return Console.ReadLine();
    }
    public double InpEdge()
    {
        Console.Write("Введите ребро: ");
        return Math.Round(Convert.ToDouble(Console.ReadLine()));
    }
    public void OutEdge() { Console.WriteLine("Ребро = " + edge); }
    public void OutTitle() { Console.WriteLine("Подпись фигуры: " + title); }
    public void OutArea() { Console.WriteLine("Площадь поверхности = " + Area()); }
    public void OutVolume() { Console.WriteLine("Объем = " + Volume()); }
    public void OutAll()
    {
        OutEdge();
        OutTitle();
        OutArea();
        OutVolume();
        Console.WriteLine();
    }

    public double Area()
    {
        return Math.Round(5 * edge * edge * Math.Sqrt(3), 3);
    }
    public double Volume() { return Math.Round(5 * edge * edge * edge / 12 * (3 + Math.Sqrt(5)), 3); }

}


