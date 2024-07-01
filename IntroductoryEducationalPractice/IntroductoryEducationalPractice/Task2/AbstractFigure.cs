namespace IntroductoryEducationalPractice.Task2;

public abstract class AbstractFigure
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
}
