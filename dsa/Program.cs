using dsa.Algorithms;
using dsa.DataStructures;

namespace dsa;

class Program
{
    static void Main(string[] args)
    {
        #region Algorithms

        Searching search = new Searching();
        Sorting sort = new();

        int[] arr = [1, 3, 51, 52, 1, 3, 5];
        int searchV = 5;

        //arr = [ 1, 2, 3, 4, 6, 7, 8, 9, 12, 14, 16, 20, 25 ] ;
        // arr = arr.OrderBy(x => x).Distinct().ToArray();

        // Console.WriteLine(search.LinearSearch(arr,43));
        // Console.WriteLine(search.BinarySearch(arr, 0, arr.Length - 1, searchV));

        foreach (var i in sort.BubbleSort(arr))
        {
            // Console.Write(i + " ");
        }

        #endregion


        #region DataStructures

        DataStructures.MyQueue<string> myQ = new();

        myQ.enqueue("hola");
        myQ.enqueue("hola1");
        myQ.enqueue("hola2");
        myQ.enqueue("hola3");
        myQ.enqueue("hola4");

        Console.WriteLine(myQ.Peek());
        Console.WriteLine(myQ.dequeue());

        Console.WriteLine(myQ.Peek());
        Console.WriteLine(myQ.dequeue());

        Console.WriteLine(myQ.Peek());
        Console.WriteLine(myQ.dequeue());

        Console.WriteLine(myQ.Peek());

        #endregion
    }
}