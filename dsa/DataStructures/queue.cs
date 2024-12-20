using System.Reflection.Metadata;
using System.Xml;

namespace dsa.DataStructures;

public class QNode<T>
{
    public T value { get; set; }
    public QNode<T>? next { get; set; }

    public QNode(T _value, QNode<T>? _next = null)
    {
        value = _value;
        next = _next;
    }
}

public class MyQueue<T>()
{
    public int lenght { get; set; } = 0;
    private QNode<T>? front { get; set; } = null;
    private QNode<T>? end { get; set; } = null;


    public void enqueue(T item)
    {
        QNode<T> node = new QNode<T>(item);
        this.lenght++;
        if (this.end == null)
        {
            this.front = node;
            this.end = this.front;
            return;
        }

        this.end.next = node;
        this.end = node;
        return;
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
            QNode<T>? front = this.front;
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