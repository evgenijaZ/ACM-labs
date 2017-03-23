using System;
using System.Windows.Forms;
class HeapSort {
    private static void swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

   private static void heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            swap(ref arr[i], ref arr[largest]);
            heapify(arr, n, largest);
        }
    }

    public void heapSort(int[] arr, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)        // Build heap (rearrange array)
            heapify(arr, n, i);

        for (int i = n - 1; i >= 0; i--)
        {       // One by one extract an element from heap
            swap(ref arr[0], ref arr[i]);
            heapify(arr, i, 0);                 // call max heapify on the reduced heap
        }
    }


    void makeArray(int[] arr, int n)
    {
        Random rnd = new Random();
        for (int counter = 0; counter < n; counter++)
        {
            arr[counter] = rnd.Next(0, 100); ;        // заполняем массив случайными значениями 
        }
    }

    string printArray(int[] arr, int n)
    {      
          return string.Join(" ", arr);
    }

    public string runGenerate(int n)
    {
        int[] arr = new int[n];
        makeArray(arr, n);
        return printArray(arr, n);
        
    }

    public string runSort(int n, int[] arr)
    {
        heapSort(arr, n);
        return printArray(arr, n);
    }

    public void makeData(int numbArrays, int step)
    {
        string[] result = new string[numbArrays+1];
        result[0] = "0 0";
        int arrayLength = 0;
        for (int i = 1; i <= numbArrays; i++) {
            arrayLength = i * step;
            int[] arr = new int[arrayLength];
            double time = 0;
            for (int j = 0; j < 10; j++)
            {
                makeArray(arr, arrayLength);
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
                swatch.Start();
                heapSort(arr, arrayLength);
                swatch.Stop();
                time += swatch.Elapsed.TotalMilliseconds;
            }
            time /= 10;
            //меньшая точнось вычислений, но быстрее
            /*
            makeArray(arr, arrayLength);
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            swatch.Start();
            heapSort(arr, arrayLength);
            swatch.Stop();
            time = swatch.Elapsed.TotalMilliseconds;
            */
            result[i]= arrayLength.ToString() + ' ' + time.ToString();
         }
        System.IO.File.WriteAllLines("data.txt", result);
        MessageBox.Show("Дані згенеровано", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}