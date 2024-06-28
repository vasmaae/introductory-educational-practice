namespace IntroductoryEducationalPractice;

public class Table
{
    private double _width;
    public double Width
    {
        get { return _width; }
        set { if (value > 0) _width = value; }
    }

    private double _length;
    public double Length
    {
        get { return _length; }
        set { if (value > 0) _length = value; }
    }

    private double _height;
    public double Height
    {
        get { return _height; }
        set { if (value > 0) _height = value; }
    }

    private int _countOfLegs;
    public int CountOfLegs
    {
        get { return _countOfLegs; }
        set { if (value > 2) _countOfLegs = value; }
    }

    private string _name;
    public string Name
    {
        get { return _name; }
        set { if (!string.IsNullOrEmpty(value)) _name = value; }
    }

    private bool _isFolding;
    public bool IsFolding
    {
        get { return _isFolding; }
        set { _isFolding = value; }
    }
}