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
    private Node<T>? head { get; set; } = null;
    private Node<T>? tail { get; set; } = null;


    public T enqueue(T item)
    {
        Node<T> node = new Node<T>(item);
        this.lenght++;
        if (this.tail == null)
        {
            this.head = node;
            this.tail = this.head;
            return item;
        }

        this.tail.next = node;
        this.tail = node;
        return item;
    }

    public T dequeue()
    {
        T item = head.value;

        if (this.head.value == null)
        {
            throw new Exception("Queue empty");
        }
        else
        {
            this.lenght--;
            Node<T> head = this.head;
            this.head = this.head.next;
            return head.value;
        }
    }

    public T Peek()
    {
        if (this.head.value == null)
        {
            throw new Exception("Queue empty");
        }
        else
        {
            return this.head.value;
        }
    }
}