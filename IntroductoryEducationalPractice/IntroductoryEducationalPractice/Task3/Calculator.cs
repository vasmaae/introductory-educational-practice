namespace IntroductoryEducationalPractice.Task3;

public class Calculator<T> where T : struct
{
    public T Calculate(T a, T b)
    {
        dynamic a1 = a;
        dynamic b1 = b;
        return a1 * b1;
    }
}
