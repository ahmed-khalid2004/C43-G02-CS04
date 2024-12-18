namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++) Console.Write(i + (i < num ? ", " : "\n"));
            #endregion

            #region Q2
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)Console.Write($"{n * i} ");
            #endregion

            #region Q3
            //Console.Write("Enter a number: ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= x; i += 2)Console.Write(i + (i < x - 1 ? " " : "\n"));
            #endregion

            #region Q4
            //Console.Write("Enter base and exponent: ");
            //int b = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(b, e));
            #endregion

            #region Q5
            //int[] marks = new int[5];
            //Console.WriteLine("Enter marks of five subjects:");
            //for (int i = 0; i < 5; i++) marks[i] = int.Parse(Console.ReadLine());
            //int total = 0;
            //foreach (int m in marks) total += m;
            //float avg = total / 5.0f;
            //float per = (total / 500.0f) * 100;
            //Console.WriteLine($"Total marks = {total}\nAverage marks = {avg}\nPercentage = {per}%");
            #endregion

            #region Q6
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //char[] rev = input.ToCharArray();
            //Array.Reverse(rev);
            //Console.WriteLine(rev);

            #endregion

            #region Q7
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());
            //int rev = 0;
            //while (num != 0)
            //{
            //    rev = rev * 10 + num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(rev);

            #endregion

            #region Q8
            //    Console.Write("Input starting number of ranges: ");
            //    int start = int.Parse(Console.ReadLine());
            //    Console.Write("Input ending number of range : ");
            //    int end = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The prime number between {start} and {end} are: ");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2) continue; 
            //    bool f = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            f = false;
            //            break;
            //        }
            //    }
            //    if (f) Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q9
            //Console.Write("Enter a number to convert: ");
            //int num = int.Parse(Console.ReadLine());
            //string bin = "";
            //int num2 = num;
            //while (num > 0)
            //{
            //    bin = (num % 2) + bin;
            //    num /= 2;
            //}
            //Console.WriteLine($"The Binary of {num2} is {bin}");

            #endregion

            #region Q10
            //Console.Write("Enter point 1 (x1 y1): ");
            //var p1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //Console.Write("Enter point 2 (x2 y2): ");
            //var p2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //Console.Write("Enter point 3 (x3 y3): ");
            //var p3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int d = p1[0] * (p2[1] - p3[1]) + p2[0] * (p3[1] - p1[1]) + p3[0] * (p1[1] - p2[1]);
            //if (d == 0) Console.WriteLine("Points lie on a straight line.");
            //else Console.WriteLine("Points dosen't lie on a straight line.");
            #endregion

            #region Q11
            //Console.Write("Enter size of identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(i == j ? "1 " : "0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12
                //Console.Write("Enter size of array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];
                //Console.WriteLine("Enter elements:");
                //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
                //int sum = 0;
                //foreach (int num in arr)  sum += num;
                //Console.WriteLine("Sum of elements: " + sum);
            #endregion

            #region Q13
                //Console.Write("Enter size of arrays: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr1 = new int[size];
                //int[] arr2 = new int[size];

                //Console.WriteLine("Enter elements of first array:");
                //for (int i = 0; i < size; i++) arr1[i] = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter elements of second array:");
                //for (int i = 0; i < size; i++) arr2[i] = int.Parse(Console.ReadLine());

                //int[] merged = new int[2 * size];
                //Array.Copy(arr1, merged, size);
                //Array.Copy(arr2, 0, merged, size, size);
                //Array.Sort(merged);

                //Console.WriteLine("Merged and sorted array:");
                //Console.WriteLine(string.Join(" ", merged));
            
            #endregion

            #region Q14
            //    Console.Write("Enter size of array: ");
            //    int size = int.Parse(Console.ReadLine());
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter elements:");
            //    for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());

            //    var freq = new Dictionary<int, int>();
            //foreach (int num in arr)
            //{
            //    if (freq.ContainsKey(num)) freq[num]++;
            //    else freq[num] = 1;
            //}
            //    Console.WriteLine("Frequency of elements:");
            //    foreach (var pair in freq)Console.WriteLine($"{pair.Key}: {pair.Value}");
            #endregion

            #region Q15
            //    Console.Write("Enter size of array: ");
            //    int size = int.Parse(Console.ReadLine());
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter elements:");
            //    for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());

            //    int max = arr[0], min = arr[0];
            //foreach (int num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}
            //    Console.WriteLine($"Maximum: {max} and Minimum: {min}");
            #endregion

            #region Q16
                //Console.Write("Enter size of array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];
                //Console.WriteLine("Enter elements:");
                //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
                //Array.Sort(arr);
                //Console.WriteLine("Second largest element: " + arr[size - 2]);
            #endregion

            #region Q17
            //    Console.Write("Enter size of array: ");
            //    int size = int.Parse(Console.ReadLine());
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter elements:");
            //    for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());

            //    var last = new Dictionary<int, int>();
            //    int mx = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    if (last.ContainsKey(arr[i]))
            //    {
            //        mx = Math.Max(mx, i - last[arr[i]]);
            //    }
            //    else
            //    {
            //        last[arr[i]] = i;
            //    }
            //}
            //    Console.WriteLine("Longest distance: " + mx);
            #endregion

            #region Q18
                //Console.Write("Enter a sentence: ");
                //string sentence = Console.ReadLine();
                //string[] words = sentence.Split(' ');
                //Array.Reverse(words);
                //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region Q19
                //Console.Write("Enter rows: ");
                //int rows = int.Parse(Console.ReadLine());
                //Console.Write("Enter columns: ");
                //int cols = int.Parse(Console.ReadLine());
                //int[,] array1 = new int[rows, cols];
                //int[,] array2 = new int[rows, cols];

                //Console.WriteLine("Enter elements of the array:");
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)array1[i, j] = int.Parse(Console.ReadLine());
                //}

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)array2[i, j] = array1[i, j];
                //}

                //Console.WriteLine("Copied array:");
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)Console.Write(array2[i, j] + " ");
                //    Console.WriteLine();
                //}
            #endregion

            #region Q20
                //Console.Write("Enter size of array: ");
                //int size = int.Parse(Console.ReadLine());
                //int[] arr = new int[size];
                //Console.WriteLine("Enter elements:");
                //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
                //Array.Reverse(arr);
                //Console.WriteLine("Reversed array: " + string.Join(" ", arr));
            #endregion
        }
    }
}
