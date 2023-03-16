namespace GB.alg_and_data_str.HW2 {
    class HeapSort {
        public static void Main(string[] args) {

            Random r = new Random();
            int n = r.Next(10, 20);
            int[] array = new int [n];
            for (int i = 0; i < n; i++) {
                array[i] = r.Next(-100, 100);
            }
            printArray(array);
            heapSort(array);
            printArray(array);
        }
        public static void heapSort(int[] array) {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)  {
                heapify(array, n, i);
            }
            for (int i = n - 1; i >= 0; i--) {
                int change = array[0];
                array[0] = array[i];
                array[i] = change;
                heapify(array, i, 0);
            }
        }

        public static void heapify(int [] array, int n, int i) {
            int largest = i;
            int left = 2*i + 1; 
            int right = 2*i + 2;

            if (left < n && array[left] > array[largest]) {
                largest = left;
            }

            if (right < n && array[right] > array[largest]) {
                largest = right;
            }
            
            if (largest != i) {
                int change = array[i];
                array[i] = array[largest];
                array[largest] = change;
                heapify(array, n, largest);
            }
        }

        public static void printArray(int [] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
