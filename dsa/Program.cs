using dsa.Algorithms;

namespace dsa;

class Program
{
    static void Main(string[] args)
    {
        Searching search = new Searching();

        int[] arr = [1, 3, 51, 52, 1, 3, 5];
        //arr = [ 1, 2, 3, 4, 6, 7, 8, 9, 12, 14, 16, 20, 25 ] ;
        arr = arr.OrderBy(x => x).Distinct().ToArray();
        int searchV = 5;


        // Console.WriteLine(search.LinearSort(arr,43));
        Console.WriteLine(search.BinarySort(arr, 0, arr.Length - 1, searchV));
    }
}