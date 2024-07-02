namespace IntroductoryEducationalPractice.Task1;

public class MyObject
{
    public MyObject() { }

    public MyObject(double width, double length, double height, int countOfLegs, string name, bool? isFolding)
    {
        Width = width;
        Length = length;
        Height = height;
        CountOfLegs = countOfLegs;
        Name = name;
        IsFolding = isFolding;
    }

    private double _width;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value > 0) _width = value;
            else throw new ArgumentException("Ширина должна быть положительной");
        }
    }

    private double _length;
    public double Length
    {
        get { return _length; }
        set
        {
            if (value > 0) _length = value;
            else throw new ArgumentException("Длина должна быть положительной");
        }
    }

    private double _height;
    public double Height
    {
        get { return _height; }
        set
        {
            if (value > 0) _height = value;
            else throw new ArgumentException("Высота должна быть положительной");
        }
    }

    private int _countOfLegs;
    public int CountOfLegs
    {
        get { return _countOfLegs; }
        set
        {
            if (value > 2) _countOfLegs = value;
            else throw new ArgumentException("Ножек должно быть больше двух");
        }
    }

    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _name = value;
            else throw new ArgumentException("Имя не может быть пустым");
        }
    }

    private bool? _isFolding;

    public bool? IsFolding
    {
        get { return _isFolding; }
        set
        {
            if (value == null) throw new ArgumentException("Стол должен либо раскладываться, либо не раскладываться");
            else _isFolding = value;
        }
    }

    public override string ToString()
    {
        return $"Стол: " +
            $"Ширина - {_width}, " +
            $"Длина - {_length}, " +
            $"Высота - {_height}, " +
            $"Количество ножек - {_countOfLegs}, " +
            $"Модель - {_name}, " +
            $"Раскладывается - {_isFolding} ";
    }
}