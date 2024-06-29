namespace IntroductoryEducationalPractice;

public class DoubleLinkedList<T>/* : IEnumerable<T>*/
{
    private Node<T>? head;
    private Node<T>? tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddLast(T Data)
    {
        Node<T> newNode = new(Data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
    }

    public void AddFirst(T Data)
    {
        Node<T> newNode = new(Data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = newNode;
            head.Previous = head;
            head = newNode;
        }
    }

    public T RemoveLast()
    {
        if (tail == null)
        {
            throw new InvalidOperationException();
        }

        T value = tail.Data;
        tail = tail.Previous;

        if (tail != null)
        {
            tail.Next = null;
        }
        else
        {
            head = null;
        }

        return value;
    }

    public T RemoveFirst()
    {
        if (head == null)
        {
            throw new InvalidOperationException();
        }

        T value = head.Data;
        head = head.Next;

        if (head != null)
        {
            head.Previous = null;
        }
        else
        {
            tail = null;
        }

        return value;
    }

    public void InsertAt(int index, T data)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T> newNode = new(data);

        if (index == 0)
        {
            AddFirst(data);
            return;
        }

        Node<T> current = head;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index - 1)
            {
                newNode.Next = current.Next;
                newNode.Previous = current;

                if (current.Next != null)
                {
                    current.Next.Previous = newNode;
                }

                current.Next = newNode;

                if (newNode.Next == null)
                {
                    tail = newNode;
                }
                return;
            }
            current = current.Next;
            currentIndex++;
        }

        throw new ArgumentOutOfRangeException(nameof(index));
    }

    public void RemoveAt(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (head == null)
        {
            throw new InvalidOperationException();
        }

        if (index == 0)
        {
            RemoveFirst();
            return;
        }

        Node<T> current = head;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index - 1)
            {
                if (current.Next == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                Node<T> nodeToRemove = current.Next;
                current.Next = nodeToRemove.Next;

                if (nodeToRemove.Next != null)
                {
                    nodeToRemove.Next.Previous = current;
                }
                else
                {
                    tail = current;
                }

                nodeToRemove.Next = null;
                nodeToRemove.Previous = null;
                return;
            }
            current = current.Next;
            currentIndex++;
        }

        throw new ArgumentOutOfRangeException(nameof(index));
    }


    public T? Get(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T> current = head;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                return current.Data;
            }
            current = current.Next;
            currentIndex++;
        }

        throw new ArgumentOutOfRangeException(nameof(index));
    }

    //public IEnumerator<T> GetEnumerator()
    //{
    //    Node<T> current = head;

    //    while (current != null)
    //    {
    //        yield return current.Data;
    //        current = current.Next;
    //    }
    //}

    //IEnumerator IEnumerable.GetEnumerator()
    //{
    //    return GetEnumerator();
    //}
}

public class Node<T>
{
    public Node<T>? Next { get; set; }
    public Node<T>? Previous { get; set; }
    public T Data { get; set; }

    public Node(T value)
    {
        Data = value;
        Next = null;
        Previous = null;
    }
}