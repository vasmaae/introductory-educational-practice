
namespace IntroductoryEducationalPractice.Task2;

public abstract class AbstractFigure : IDrawable
{
    public abstract double Width { get; set; }
    public abstract double Height { get; set; }

    public int X { get; private set; }
    public int Y { get; private set; }

    public AbstractFigure(double width, double height)
    {
        Random random = new();

        Width = width;
        Height = height;
        X = random.Next(0, 100);
        Y = random.Next(0, 100);
    }

    public abstract double Area();

    public abstract double Perimeter();

    public void Draw(Graphics g)
    {
        Pen pen = new(Color.Black, 3);
        Brush brush = new SolidBrush(Color.Black);
        DrawFigure(g, pen, brush);
    }

    protected abstract void DrawFigure(Graphics g, Pen pen, Brush brush);
}
