using System.Text;

namespace IntroductoryEducationalPractice;

public class CircularList<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int _count;
    public int Count => _count;

    public CircularList()
    {
        head = null;
        tail = null;
        _count = 0;
    }

    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.Next = head;
            head.Previous = head;
        }
        else
        {
            newNode.Previous = tail;
            newNode.Next = head;
            tail.Next = newNode;
            head.Previous= newNode;
            tail = newNode;
        }

        _count++;
    }

    public bool Remove(T data)
    {
        Node<T> current = head;

        if (current == null)
        {
            return false;
        }

        do
        {
            if (current.Data.Equals(data))
            {
                if (current == head && current == tail)
                {
                    head = null;
                    tail = null;
                }
                else if (current == head)
                {
                    head = head.Next;
                    head.Previous = tail;
                    tail.Next = head;
                }
                else if (current == tail)
                {
                    tail = tail.Previous;
                    tail.Next = head;
                    head.Previous = tail;
                }
                else
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                }

                _count--;
                return true;
            }

            current = current.Next;
        } while (current != head);

        return false;
    }

    public string GetString()
    {
        Node<T> current = head;

        if (current == null)
        {
            return "Список пуст";
        }

        StringBuilder sb = new();
        do
        {
            sb.Append(current.Data + " ");
            current = current.Next;
        } while (current != head);

        return sb.ToString();
    }
}
