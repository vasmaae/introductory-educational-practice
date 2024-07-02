
namespace IntroductoryEducationalPractice.Task2;
//rename class
public class Rectangle : AbstractFigure
{
    public Rectangle(double width, double height) : base(width, height) { }

    public override double Width { get; set; }
    public override double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }

    protected override void DrawFigure(Graphics g, Pen pen, Brush brush)
    {
        g.DrawRectangle(pen, X, Y, (float)Width, (float)Height);
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public override string ToString()
    {
        return $"Прямоугольник {Width}x{Height}";
    }
}
