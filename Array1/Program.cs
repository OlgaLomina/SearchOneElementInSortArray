using System;

//Find the element that appears once in a sorted array where all other elements appear twice one after another.
//Find that element in 0(logn) complexity.
//Input:   arr[] = { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}
//Output:  4   

class Program
{
    static int search(int[] arr, int start, int end)
    {
        if (start > end)
            return -1;

        if (start == end)
            return arr[start];
       
        int mid = (start + end) / 2;
        if (mid%2 == 0)
        {
            //even //чётное
            //first occurence
            if (arr[mid] == arr[mid + 1])
                return search(arr, (mid + 2), end);
            else
                return search(arr, start, mid);
        }
        else
        {
                //odd //нечётное
                //second occurence
            if (arr[mid] == arr[mid-1])
                return search(arr, (mid +1), end); //вправо
            else
                return search(arr, start, (mid-1));
        }
      }

    public static void Main()
    {
        int[] arr = { 1, 1, 3, 3, 5, 5, 7, 7, 8, 8, 9 };
        int n = arr.Length;

        int val = search(arr, 0, n - 1);
        if (val > 0)
        { 
            Console.Write(val + "            ");
            Console.ReadLine();
        }
        Console.Write("It is not found    ");
        Console.ReadLine();
    }
}