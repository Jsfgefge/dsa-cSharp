using System.Reflection.Metadata;
using System.Xml;

namespace dsa.DataStructures;

public class Node<T>
{
    public T value { get; set; }
    public Node<T>? next { get; set; }

    public Node(T _value, Node<T>? _next = null)
    {
        value = _value;
        next = _next;
    }
}

public class MyQueue<T>()
{
    public int lenght { get; set; } = 0;
    private Node<T>? front { get; set; } = null;
    private Node<T>? end { get; set; } = null;


    public T enqueue(T item)
    {
        Node<T> node = new Node<T>(item);
        this.lenght++;
        if (this.end == null)
        {
            this.front = node;
            this.end = this.front;
            return item;
        }

        this.end.next = node;
        this.end = node;
        return item;
    }

    public T dequeue()
    {
        T item = front.value;

        if (this.front.value == null)
        {
            throw new Exception("Queue empty");
        }
        else
        {
            this.lenght--;
            Node<T> front = this.front;
            this.front = this.front.next;
            return front.value;
        }
    }

    public T Peek()
    {
        if (this.front.value == null)
        {
            throw new Exception("Queue empty");
        }
        else
        {
            return this.front.value;
        }
    }
}