using System.Reflection.Metadata;

namespace dsa.DataStructures;

public class SNode<T>
{
    public T value { get; set; }
    public SNode<T>? prev { get; set; }

    public SNode(T _value, SNode<T>? _prev = null)
    {
        value = _value;
        prev = _prev;
    }
}

public class Stack<T>
{
    public int lenght { get; set; }
    private SNode<T>? head { get; set; }

    private Stack(SNode<T>? _head = null, int _lenght = 0)
    {
        lenght = _lenght;
        head = _head;
    }

    public void Push(T item)
    {
        SNode<T> node = new SNode<T>(item);
        this.lenght++;
        if (this.head == null)
        {
            this.head = node;
            return;
        }
        else
        {
            node.prev = this.head;
            this.head = node;
        }
    }

    public T Pop()
    {
        this.lenght = Math.Max(0, this.lenght--);
        if (this.lenght == 0)
        {
            SNode<T> head = this.head;
            this.head = null;
            head = null;
            return head.value;
        }
        else
        {
            SNode<T> head = this.head;
            this.head = head?.prev;
            head = null;
            return head.value;
        }
    }

    public T Peek()
    {
        return this.head.value;
    }
}