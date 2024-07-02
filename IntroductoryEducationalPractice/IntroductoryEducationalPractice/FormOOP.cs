using IntroductoryEducationalPractice.Task1;
using IntroductoryEducationalPractice.Task2;
using IntroductoryEducationalPractice.Task3;

namespace IntroductoryEducationalPractice;

public partial class FormOOP : Form
{
    private List<MyObject> objects = new();
    private List<AbstractFigure> figures = new();

    public FormOOP()
    {
        InitializeComponent();
    }

    private void ButtonCreateObject_Click(object sender, EventArgs e)
    {
        MyObject obj = new();

        try
        {
            obj.Length = double.Parse(textBoxHeight.Text);
            obj.Width = double.Parse(textBoxWidth.Text);
            obj.Height = double.Parse(textBoxHeight.Text);
            obj.CountOfLegs = int.Parse(numericUpDownCountOfLegs.Text);
            obj.Name = textBoxName.Text;
            obj.IsFolding =
                (radioButtonIsFolding.Checked == true) ? true :
                ((radioButtonIsNotFolding.Checked == true) ? false :
                null);
            objects.Add(obj);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (FormatException ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ButtonShowObjects_Click(object sender, EventArgs e)
    {
        listBoxObjects.Items.Clear();
        foreach (MyObject obj in objects) listBoxObjects.Items.Add(obj.ToString());
    }

    private void ButtonCreateFigure_Click(object sender, EventArgs e)
    {
        AbstractFigure figure = new Task2.Rectangle(int.Parse(textBoxFigureWidth.Text), int.Parse(textBoxFigureHeight.Text));
        figures.Add(figure);
        listBoxFigures.Items.Add(figure);
    }

    private void ButtonCreateFilledFigure_Click(object sender, EventArgs e)
    {
        AbstractFigure filledFigure = new FilledCircle(int.Parse(textBoxFigureWidth.Text), int.Parse(textBoxFigureHeight.Text));
        figures.Add(filledFigure);
        listBoxFigures.Items.Add(filledFigure);
    }

    private void ButtonShowFigure_Click(object sender, EventArgs e)
    {
        IDrawable figure = (IDrawable)figures[listBoxFigures.SelectedIndex];
        Bitmap bitmap = new(pictureBoxFigure.Width, pictureBoxFigure.Height);
        Graphics g = Graphics.FromImage(bitmap);
        figure.Draw(g);
        pictureBoxFigure.Image = bitmap;
    }

    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        if (double.TryParse(textBoxValue1.Text, out double value1) && double.TryParse(textBoxValue2.Text, out double value2))
        {
            var calculator = new Calculator<double>();
            textBoxResult.Text = calculator.Calculate(value1, value2).ToString();
        }
    }
}
