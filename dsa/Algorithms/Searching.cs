namespace dsa.Algorithms;
public class Searching
{
    public bool LinearSort(int[] arr, int v)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == v)
            {
                return true;
            }
        }

        return false;
    }

    public bool BinarySort(int[] arr, int lo, int up, int n)
    {
        while (lo < up)
        {
            int m = (lo + (up - lo) / 2);
            int v = arr[m];
            if (v == n)
            {
                return true;
            }
            else if (v < m)
            {
                lo = m + 1;
            }
            else
            {
                up = m;
            }
        }

        return false;
    }
}