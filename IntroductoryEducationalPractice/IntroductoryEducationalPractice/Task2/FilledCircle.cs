namespace IntroductoryEducationalPractice.Task2;

public class FilledCircle : AbstractFigure
{
    public FilledCircle(double width, double height) : base(width, height) { }

    public override double Width { get; set; }
    public override double Height { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow((Width / 2), 2);
    }

    protected override void DrawFigure(Graphics g, Pen pen, Brush brush)
    {
        g.DrawEllipse(pen, X, Y, (float)Width, (float)Height);
        g.FillEllipse(brush, X, Y, (float)Width - 1, (float)Height - 1);
    }

    public override double Perimeter()
    {
        return Math.PI * Width;
    }

    public override string ToString()
    {
        return $"Закрашенный круг {Width}x{Height}";
    }
}
