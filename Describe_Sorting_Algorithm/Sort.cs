using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Describe_Sorting_Algorithm
{
    static class SortInteger
    {
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        #region Selection Sort
        public static string Alg_SelectionSort
        {
            get
            {
                return "void SelectionSort(int[] arr)\r\n{\r\n\tint n = arr.Length;\r\n\tfor (int i = 0; i < n - 1; i++)\r\n\t{\r\n\t\tint min_index = i;\r\n\t\tfor (int j = i + 1; j < n; j++)\r\n\t\t\tif (arr[j] < arr[min_index])\r\n\t\t\t\tmin_index = j;\r\n\t\tSwap(ref arr[i], ref arr[min_index]);\r\n\t}\r\n}";
            }
        }
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_index = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_index])
                        min_index = j;

                // Swap the found minimum element with the first 
                // element 
                Swap(ref arr[i], ref arr[min_index]);
            }
        }
        #endregion

        #region Insertion Sort
        public static string Alg_InsertionSort
        {
            get
            {
                return "void InsertionSort(int[] arr)\n{\n\tint n = arr.Length;\n\tfor (int i = 1; i < n; i++)\n\t{\n\t\tint key = arr[i];\n\t\tint j = i - 1;\n\n\t\twhile (j >= 0 && arr[j] > key)\n\t\t{\n\t\t\tarr[j + 1] = arr[j];\n\t\t\tj = j - 1;\n\t\t}\n\t\tarr[j + 1] = key;\n\t}\n}";
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        #endregion

        #region Merge Sort

        public static string Alg_MergeSort
        {
            get
            {
                return "void Merge(int[] arr, int left, int mid, int right)\n{\n    // Find sizes of two\n    // subarrays to be merged\n    int n1 = mid - left + 1;\n    int n2 = right - mid;\n    // Create temp arrays\n    int[] L = new int[n1];\n    int[] R = new int[n2];\n    int i, j;\n    // Copy data to temp arrays\n    for (i = 0; i < n1; ++i)\n        L[i] = arr[left + i];\n    for (j = 0; j < n2; ++j)\n        R[j] = arr[mid + 1 + j];\n    // Merge the temp arrays\n    // Initial indexes of first\n    // and second subarrays\n    i = 0;\n    j = 0;\n    // Initial index of merged\n    // subarry array\n    int k = left;\n    while (i < n1 && j < n2)\n    {\n        if (L[i] <= R[j])\n        {\n            arr[k] = L[i];\n            i++;\n        }\n        else\n        {\n            arr[k] = R[j];\n            j++;\n        }\n        k++;\n    }\n    // Copy remaining elements\n    // of L[] if any\n    while (i < n1)\n    {\n        arr[k] = L[i];\n        i++;\n        k++;\n    }\n    // Copy remaining elements\n    // of R[] if any\n    while (j < n2)\n    {\n        arr[k] = R[j];\n        j++;\n        k++;\n    }\n}\n// Main function that\n// sorts arr[l..r] using\n// merge()\nvoid MergeSort(int[] arr, int left, int right)\n{\n    if (left < right)\n    {\n        // Find the middle\n        // point\n        int m = left + (right - left) / 2;\n        // Sort first and\n        // second halves\n        MergeSort(arr, left, m);\n        MergeSort(arr, m + 1, right);\n        // Merge the sorted halves\n        Merge(arr, left, m, right);\n    }\n}";
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[mid + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle
                // point
                int m = left + (right - left) / 2;

                // Sort first and
                // second halves
                MergeSort(arr, left, m);
                MergeSort(arr, m + 1, right);

                // Merge the sorted halves
                Merge(arr, left, m, right);
            }
        }


        #endregion

        #region Heap Sort
        public static string Alg_HeapSort
        {
            get
            {
                return "void HeapSort(int[] arr)\n{\n    int n = arr.Length;\n\n    // Build heap (rearrange array)\n    for (int i = n / 2 - 1; i >= 0; i--)\n        heapify(arr, n, i);\n\n    // One by one extract an element from heap\n    for (int i = n - 1; i > 0; i--)\n    {\n        // Move current root to end\n        Swap(ref arr[0], ref arr[i]);\n\n        // call max heapify on the reduced heap\n        heapify(arr, i, 0);\n    }\n}\n\n\n\n// To heapify a subtree rooted with node i which is\n// an index in arr[]. n is size of heap\nvoid heapify(int[] arr, int n, int i)\n{\n    int largest = i; // Initialize largest as root\n    int l = 2 * i + 1; // left = 2*i + 1\n    int r = 2 * i + 2; // right = 2*i + 2\n\n    // If left child is larger than root\n    if (l < n && arr[l] > arr[largest])\n        largest = l;\n\n    // If right child is larger than largest so far\n    if (r < n && arr[r] > arr[largest])\n        largest = r;\n\n    // If largest is not root\n    if (largest != i)\n    {\n        Swap(ref arr[i], ref arr[largest]);\n\n        // Recursively heapify the affected sub-tree\n        heapify(arr, n, largest);\n    }\n}";
            }
        }
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                Swap(ref arr[0], ref arr[i]);

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        static void heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);

                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }
        #endregion

        #region Bubble Sort

        public static string Alg_BubbleSort
        {
            get
            {
                return "void BubbleSort(int[] arr)\n{\n    int n = arr.Length;\n    for (int i = 0; i < n - 1; i++)\n        for (int j = 0; j < n - i - 1; j++)\n        {\n            if (arr[j] > arr[j + 1])\n            {\n                Swap(ref arr[j], ref arr[j + 1]);\n            }\n        }\n}";
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
        }

        #endregion

        #region Quick Sort

        public static string Alg_QuickSort
        {
            get
            {
                return "void QuickSort(int[] arr, int Left, int Right)\n{\n    int i = Left, j = Right, Mid = (Left + Right) / 2;\n    int x = arr[Mid];\n\n    do\n    {\n        // repeat until arr[i] >= x\n        while (arr[i] < x)\n            i++;\n\n        // repeat until arr[j] <= x\n        while (arr[j] > x)\n            j--; \n\n        if (i <= j)\n        {\n            Swap(ref arr[i], ref arr[j]);\n            i++; j--;\n        }\n    } while (i < j);\n\n    if (Left < j)\n        QuickSort(arr, Left, j);\n\n    if (Right > i)\n        QuickSort(arr, i, Right);\n}";
            }
        }
        public static void QuickSort(int[] arr, int Left, int Right)
        {
            int i = Left, j = Right, Mid = (Left + Right) / 2;
            int x = arr[Mid];

            do
            {
                // repeat until arr[i] >= x
                while (arr[i] < x)
                    i++;

                // repeat until arr[j] <= x
                while (arr[j] > x)
                    j--; 
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++; j--;
                }
            } while (i < j);

            if (Left < j)
                QuickSort(arr, Left, j);

            if (Right > i)
                QuickSort(arr, i, Right);
        }

        #endregion

    }
}
