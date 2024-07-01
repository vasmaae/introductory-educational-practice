
namespace IntroductoryEducationalPractice.Task2;

public class FilledFigure : AbstractFigure, IDrawable
{
    public FilledFigure(double width, double height) : base(width, height)
    {
    }

    public override double Width { get; set; }
    public override double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }

    public void Draw(PictureBox pictureBox)
    {
        Brush brush = new SolidBrush(Color.Black);
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        Graphics g = Graphics.FromImage(bitmap);
        g.FillEllipse(brush, X, Y, (float)Width, (float)Height);
        pictureBox.Image = bitmap;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
