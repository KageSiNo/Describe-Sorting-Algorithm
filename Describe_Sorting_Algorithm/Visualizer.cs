using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Describe_Sorting_Algorithm
{
    class Visualizer
    {
        int fps;
        double elapsedTime;
        int swaps;
        int comparisons;

        Graphics MainGraphics { get; set; }
        public List<Bar> ListBar { get; set; }

        public int[] IntArr { get; set; }
        public int NumItem { get; set; }

        int Time_Delay { get; set; }
        public bool IsRunning { get; private set; }

        public int FPS
        {
            get
            {
                return fps;
            }

            set
            {
                if (value > 0)
                    fps = value;
                else
                    fps = 50;
                Time_Delay = 1000 / fps;
            }
        }


        public double ElapsedTime
        {
            get
            {
                return this.elapsedTime;
            }

            private set
            {
                this.elapsedTime = value;
                if (elapsedTimeChange != null)
                {
                    elapsedTimeChange(this, EventArgs.Empty);
                }
            }
        }

        public int Swaps
        {
            get
            {
                return this.swaps;
            }

            private set
            {
                this.swaps = value;
                if (swapsChange != null)
                {
                    swapsChange(this, EventArgs.Empty);
                }
            }
        }

        public int Comparisons
        {
            get
            {
                return this.comparisons;
            }

            private set
            {
                this.comparisons = value;
                if (comparisonsChange != null)
                {
                    comparisonsChange(this, EventArgs.Empty);
                }
            }
        }

        #region Create Event
        private event EventHandler elapsedTimeChange;
        private event EventHandler swapsChange;
        private event EventHandler comparisonsChange;

        public event EventHandler ElapsedTimeChange
        {
            add
            {
                elapsedTimeChange += value;
            }
            remove
            {
                elapsedTimeChange -= value;
            }
        }
        public event EventHandler SwapsChange
        {
            add
            {
                swapsChange += value;
            }
            remove
            {
                swapsChange -= value;
            }
        }
        public event EventHandler ComparisonsChange
        {
            add
            {
                comparisonsChange += value;
            }
            remove
            {
                comparisonsChange -= value;
            }
        }

        #endregion

        public Visualizer(Graphics g, int fps)
        {
            ListBar = new List<Bar>();
            this.NumItem = 50;
            this.MainGraphics = g;
            this.IsRunning = false;
            this.FPS = fps;

        }

        public void InitArray(int minValue, int maxValue, float width, float y)
        {

            if (IsRunning)
                return;
            ResetInfoSort();
            IntArr = new int[NumItem];
            ListBar.Clear();
            Random rnd = new Random();
            for (int i = 0; i < NumItem; i++)
            {
                int value = rnd.Next(minValue, maxValue);
                Bar bar = new Bar(width, width * i + Bar.MARGIN_LEFT * i + 4, y, value);
                ListBar.Add(bar);
                IntArr[i] = value;
            }
        }

        public void DrawArray(Graphics g)
        {
            foreach (var item in ListBar)
            {
                item.Draw(g);
            }
        }

        void Swap(int i, int j)
        {
            ListBar[i].Clear(MainGraphics);
            ListBar[j].Clear(MainGraphics);

            var tmp = ListBar[i].Value;
            ListBar[i].Value = ListBar[j].Value;
            ListBar[j].Value = tmp;


            SetColorSwap(i, j);

            Swaps += 1;

        }

        int Compare(int a, int b)
        {
            Comparisons += 1;
            return a.CompareTo(b);
        }

        void SetColorSwap(int i, int j)
        {
            Color cl_i = ListBar[i].Color;
            Color cl_j = ListBar[j].Color;

            ListBar[i].Color = ConstColor.SWAP_BAR;
            ListBar[j].Color = ConstColor.SWAP_BAR;

            ListBar[i].Draw(MainGraphics);
            ListBar[j].Draw(MainGraphics);

            //Delay
            Thread.Sleep(Time_Delay);

            ListBar[i].Color = cl_i;
            ListBar[j].Color = cl_j;

            ListBar[i].Draw(MainGraphics);
            ListBar[j].Draw(MainGraphics);
        }

        Color GetColorByLevel(int index)
        {
            int radius = (NumItem) / 5;

            if (index >= radius * 4)
            {
                return Color.FromArgb(119, 185, 222);
            }
            else if (index >= radius * 3)
            {
                return Color.FromArgb(39, 243, 124);
            }
            else if (index >= radius * 2)
            {
                return Color.FromArgb(108, 243, 39);
            }
            else if (index >= radius)
            {
                return Color.FromArgb(243, 227, 39);
            }

            return Color.FromArgb(243, 133, 39);

        }


        void UpdateColorForBars()
        {


            for (int i = 0; i < ListBar.Count; i++)
            {
                ListBar[i].Color = ConstColor.BROWSER_BAR;
                ListBar[i].Draw(MainGraphics);
                ListBar[i].Color = GetColorByLevel(i);
                //Delay
                Thread.Sleep(Time_Delay + 10);


                ListBar[i].Draw(MainGraphics);


            }
        }

        public void ResetArray()
        {
            if (IsRunning)
                return;
            ResetInfoSort();
            for (int i = 0; i < ListBar.Count; i++)
            {
                ListBar[i].Clear(MainGraphics);
                ListBar[i].Color = ConstColor.DEFAULT_BAR;
                ListBar[i].Value = IntArr[i];
                ListBar[i].Draw(MainGraphics);
            }
        }

        void ResetInfoSort()
        {
            this.Comparisons = 0;
            this.Swaps = 0;
            this.ElapsedTime = 0;
        }

        public string GetAlgorithm(string alg)
        {
            switch (alg)
            {
                case "Selection Sort":
                    return SortInteger.Alg_SelectionSort;

                case "Insertion Sort":
                    return SortInteger.Alg_InsertionSort;

                case "Bubble Sort":
                    return SortInteger.Alg_BubbleSort;

                case "Merge Sort":
                    return SortInteger.Alg_MergeSort;

                case "Quick Sort":
                    return SortInteger.Alg_QuickSort;

                case "Heap Sort":
                    return SortInteger.Alg_HeapSort;
                default:
                    return "";
            }

            return "";
        }


        public void Run(string alg)
        {
            if (IsRunning || ListBar.Count == 0)
                return;
            Action action1;
            Action action2;
            var arrClone = (int[])IntArr.Clone();
            switch (alg)
            {
                case "Selection Sort":
                    action1 = Visualizer_SelectionSort;

                    action2 = () =>
                    {
                        SortInteger.SelectionSort(arrClone);
                    };

                    break;
                case "Insertion Sort":
                    action1 = Visualizer_InsertionSort;

                    action2 = () =>
                    {
                        SortInteger.InsertionSort(arrClone);
                    };
                    break;
                case "Bubble Sort":
                    action1 = Visualizer_BubbleSort;

                
                    action2 = () =>
                    {
                        SortInteger.BubbleSort(arrClone);
                    };
                    break;

                case "Merge Sort":
                    action1 = Visualizer_MergeSort;

                    action2 = () =>
                    {
                        SortInteger.MergeSort(arrClone, 0, arrClone.Length - 1);
                    };
                    break;
                case "Quick Sort":
                    action1 = Visualizer_QuickSort;

                    action2 = () =>
                    {
                        SortInteger.QuickSort(arrClone, 0, arrClone.Length - 1);
                    };
                    break;
                case "Heap Sort":
                    action1 = Visualizer_HeapSort;


                    action2 = () =>
                    {
                        SortInteger.HeapSort(arrClone);
                    };
                    break;
                default:
                    return;
            }

            IsRunning = true;
            ResetInfoSort();
            this.ElapsedTime = CaculateElapsedTime(action2);
            Thread t = new Thread(() =>
            {
                action1();
                UpdateColorForBars();
                IsRunning = false;
            });

            t.Name = "Run Visualizer";
            t.Priority = ThreadPriority.AboveNormal;
            t.IsBackground = true;
            t.Start();

        }

        public void Sniff(Action action, int timeUpdate = 0)
        {
            if (!IsRunning)
                return;
            Thread t = new Thread(() =>
            {
                int tmp1 = -1, tmp2 = -1;

                while (IsRunning)
                {
                    if (tmp1 != Comparisons || tmp2 != Swaps)
                    {
                        action();
                    }
                    tmp1 = Comparisons;
                    tmp2 = Swaps;
                    Thread.Sleep(timeUpdate);
                }

            });

            t.IsBackground = true;
            t.Start();


        }

        double CaculateElapsedTime(Action func)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            func();
            watch.Stop();
            var elapsed = watch.Elapsed;
            return elapsed.TotalMilliseconds;
        }

        #region Seclection Sort
        void Visualizer_SelectionSort()
        {

            int n = ListBar.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (Compare(ListBar[j].Value, ListBar[min_idx].Value) < 0)
                    {
                        min_idx = j;
                    }

                ListBar[i].Color = GetColorByLevel(i);

                Swap(i, min_idx);

            }
        }


        #endregion

        #region Insertion Sort

        void Visualizer_InsertionSort()
        {

            int n = ListBar.Count;

            for (int i = 1; i < n; i++)
            {

                int key = ListBar[i].Value;
                int j = i - 1;
                ListBar[i].Clear(MainGraphics);

                while (Compare(j, 0) >= 0 && Compare(ListBar[j].Value, key) > 0)
                {
                    ListBar[j + 1].Clear(MainGraphics);
                    ListBar[j].Clear(MainGraphics);


                    // It is not necessary to swap
                    var tmp = ListBar[j + 1].Value;
                    ListBar[j + 1].Value = ListBar[j].Value;
                    ListBar[j].Value = tmp;


                    //SetColorSwap(j + 1, j);


                    Color cl_i = ListBar[j + 1].Color;
                    Color cl_j = ListBar[j].Color;

                    ListBar[j + 1].Color = ConstColor.SWAP_BAR;
                    ListBar[j].Color = ConstColor.SWAP_BAR;

                    ListBar[j + 1].Draw(MainGraphics);
                    ListBar[j].Draw(MainGraphics);

                    //Delay
                    Thread.Sleep(Time_Delay);

                    ListBar[j + 1].Color = cl_i;
                    ListBar[j].Color = cl_j;

                    ListBar[j + 1].Draw(MainGraphics);
                    ListBar[j].Draw(MainGraphics);

                    j = j - 1;


                }


                ListBar[j + 1].Value = key;



                ListBar[i].Color = GetColorByLevel(i);

            }

        }


        #endregion

        #region Bubble Sort
        void Visualizer_BubbleSort()
        {
    

            int n = ListBar.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)

                    if (Compare(ListBar[j].Value, ListBar[j + 1].Value) > 0)
                    {                        
                        Swap(j, j + 1);
                        ListBar[j].Color = GetColorByLevel(j);
                    }
               


            }
        }

        #endregion

        #region Merge Sort
        void Visualizer_MergeSort()
        {

            MergeSort(ListBar, 0, ListBar.Count - 1);
        }

        void Merge(List<Bar> arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; i++)
                L[i] = arr[left + i].Value;
            for (j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j].Value;

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = left;
            while (Compare(i, n1) < 0 && Compare(j, n2) < 0)
            {
                arr[k].Clear(MainGraphics);
                if (Compare(L[i], R[j]) <= 0)
                {
                    arr[k].Value = L[i];
                    i++;
                }
                else
                {
                    arr[k].Value = R[j];
                    j++;
                }

                Thread.Sleep(Time_Delay);
                SetColorSwap(k, k);
                arr[k].Color = GetColorByLevel(k);

                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (Compare(i, n1) < 0)
            {
                arr[k].Clear(MainGraphics);

                arr[k].Value = L[i];

                Thread.Sleep(Time_Delay);
                SetColorSwap(k, k);
                arr[k].Color = GetColorByLevel(k);

                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (Compare(j, n2) < 0)
            {
                arr[k].Clear(MainGraphics);

                arr[k].Value = R[j];

                Thread.Sleep(Time_Delay);
                SetColorSwap(k, k);
                arr[k].Color = GetColorByLevel(k);
                j++;
                k++;
            }



        }

        void MergeSort(List<Bar> arr, int left, int right)
        {

            if (Compare(left, right) < 0)
            {
                // Find the middle
                // point
                int mid = left + (right - left) / 2;

                // Sort first and
                // second halves
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);

            }
        }


        #endregion

        #region Quick Sort
        void Visualizer_QuickSort()
        {


            QuickSort(ListBar, 0, ListBar.Count - 1);
        }
        void QuickSort(List<Bar> arr, int left, int right)
        {
            int i = left, j = right;
            int mid = (left + right) / 2;
            int key = arr[mid].Value;

            do
            {
                while (Compare(arr[i].Value, key) < 0)
                    i++;

                while (Compare(arr[j].Value, key) > 0)
                    j--;

                if (Compare(i, j) <= 0)
                {
                    arr[i].Color = GetColorByLevel(i);
                    arr[j].Color = GetColorByLevel(j);
                    Swap(i, j);

                    i++;
                    j--;
                }
            } while (Compare(i, j) < 0);


            if (Compare(left, j) < 0)
                QuickSort(arr, left, j);

            if (Compare(right, i) > 0)
                QuickSort(arr, i, right);
        }





        #endregion

        #region Heap Sort
        void Visualizer_HeapSort()
        {
            HeapSort(ListBar);
        }

        void heapify(List<Bar> arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (Compare(l, n) < 0 && Compare(arr[l].Value, arr[largest].Value) > 0)
            {
                largest = l;
                arr[largest].Color = GetColorByLevel(largest);
            }

            // If right child is larger than largest so far
            if (Compare(r, n) < 0 && Compare(arr[r].Value, arr[largest].Value) > 0)
            {
                largest = r;
                arr[largest].Color = GetColorByLevel(largest);
            }

            // If largest is not root
            if (Compare(largest, i) != 0)
            {
                Swap(i, largest);
                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);

            }

            arr[i].Color = GetColorByLevel(i);

        }
        void HeapSort(List<Bar> arr)
        {
            int n = arr.Count;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                Swap(0, i);
                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }




        #endregion



    }



}
