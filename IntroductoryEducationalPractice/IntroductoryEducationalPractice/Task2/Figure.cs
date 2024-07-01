
namespace IntroductoryEducationalPractice.Task2;
//rename class
public class Figure : AbstractFigure, IDrawable
{
    public Figure(double width, double height) : base(width, height)
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
        Pen pen = new(Color.Black);
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        Graphics g = Graphics.FromImage(bitmap);
        g.DrawEllipse(pen, X, Y, (float)Width, (float)Height);
        pictureBox.Image = bitmap;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
