namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($"{i}");
            //    if (i < num) Console.Write($",");
            //}
            #endregion

            #region Q2
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) Console.Write($"{num * i} ");
            #endregion

            #region Q3
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= num; i++) Console.Write(i % 2 == 0 ? i : " ");
            #endregion

            #region Q4
            //int Base = Convert.ToInt32(Console.ReadLine());
            //int Exponent = Convert.ToInt32(Console.ReadLine());
            //int x = 1;
            //for (int i = 1; i <= Exponent; i++)
            //{
            //    x *= Base;
            //}
            //Console.WriteLine(x);
            #endregion

            #region Q5
            //int[] num = new int[5];
            //int sum = 0;
            //Console.WriteLine("Enter Marks of five subjects: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += num[i];
            //}
            //Console.WriteLine($"Total marks = {sum}");
            //float avg = sum / 5;
            //Console.WriteLine($"Average Marks = {avg}");
            //Console.WriteLine($"Percentage = {avg}");
            #endregion

            #region Q6
            //string? s = Console.ReadLine() ?? "0";
            //for (int i = s.Length - 1; i >= 0; i--)Console.Write(s[i]);
            #endregion

            #region Q7
            //int num = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //while (num != 0)
            //{
            //    rev = rev * 10 + num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(rev);

            #endregion

            #region Q8
            //Console.Write($"Input starting number of ranges: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write($"Input ending number of ranges: ");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The prime number between {start} and {end} are: ");
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
            //Console.WriteLine($"The Binary of {num2} is {bin}.");

            #endregion

            #region Q10
            //Console.Write("Enter point 1 (x1 y1): ");
            //int x1=int.Parse(Console.ReadLine());
            //int y1=int.Parse(Console.ReadLine());
            //Console.Write("Enter point 2 (x2 y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter point 3 (x3 y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());
            //int d = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 *(y1 - y2);
            //if (d == 0) Console.WriteLine("Points lie on a straight line.");
            //else Console.WriteLine("Points dosen't lie on a straight line.");
            #endregion

            #region Q11
            //Console.Write("Enter size of identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)Console.Write("* ");
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter elements:");
            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine("Sum of elements: " + sum);
            #endregion

            #region Q13
            //int size=int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //int[] arr2 = new int[size];
            //int[] arr3 = new int[size*2];
            //int index = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    arr3[index] = arr1[i];
            //    index++;
            //}
            //for (int i = 0; i < size; i++) {
            //    arr2[i] = int.Parse(Console.ReadLine());
            //    arr3[index] = arr2[i];
            //    index++;
            //}
            //for (int i = 0; i < size*2-1; i++)
            //    for (int j = 0; j < size*2-1-i; j++)
            //    {
            //      if(arr3[j] > arr3[j + 1])
            //        {
            //            int temp=arr3[j];
            //            arr3[j]=arr3[j+1];
            //            arr3[j+1]=temp;
            //        }
            //    }
            //for (int i = 0; i < size*2; i++)
            //{
            // Console.Write($"{arr3[i]} ");
            //}

            #endregion

            #region Q14
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int index = 0;
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            //int[] visited = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    if (visited[i] != 1)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //                visited[j] = 1;
            //            }
            //        }
            //        Console.WriteLine($"{arr[i]} : {count}");
            //    }
            //}
            #endregion

            #region Q15
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter elements:");
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            //int max = arr[0], min = arr[0];
            //foreach (int num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}
            //Console.WriteLine($"Maximum: {max} and Minimum: {min}");
            #endregion

            #region Q16
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter elements:");
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            //int largest = arr[0];
            //int secondLargest = arr[0];
            //for (int i = 0; i < size; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = arr[i];
            //    }
            //}
            //        Console.WriteLine("Second largest element: " + secondLargest);
            #endregion

            #region Q17
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.Write("Enter elements: ");
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            //int maxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j]) 
            //        {
            //            int distance = j-i-1;
            //            if (distance > maxDistance)maxDistance = distance;
            //        }
            //    }
            //}
            //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            #endregion

            #region Q18
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //for (int i = 0; i < words.Length; i++)Console.Write(words[i]+" ");
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
            //    for (int j = 0; j < cols; j++) array1[i, j] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++) array2[i, j] = array1[i, j];
            //Console.WriteLine("Copied array:");
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++) Console.Write(array2[i, j] + " ");
            #endregion

            #region Q20
            //Console.Write("Enter size of array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter elements:");
            //for (int i = 0; i < size; i++) arr[i] = int.Parse(Console.ReadLine());
            //Console.Write("Reversed array: ");
            //for (int i = size-1; i >= 0; i--)Console.Write(arr[i]+" ");
            #endregion
        }      
    }
}
