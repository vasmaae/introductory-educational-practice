namespace IntroductoryEducationalPractice;

public class Queue<T>
{
    public int Count { get; private set; }
    public DoubleLinkedList<T> list { get; private set; }

    public Queue()
    {
        list = new();
        Count = 0;
    }

    public void Enqueue(T item)
    {
        Count++;
        list.AddLast(item);
    }

    public T Dequeue()
    {
        Count--;
        return list.RemoveFirst();
    }

    public T Peek()
    {
        return list.Get(0);
    }

    public bool isEmpty()
    {
        return Count == 0;
    }
}
