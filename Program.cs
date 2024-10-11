namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 132, 312, 34, 54, 13 };
            Console.WriteLine("first arr");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            InsertArray(ref arr, 99, 9, 11);
        }
        static void InsertArray(ref int[] arr, params int[] value)
        {
            int[] newArray = new int[arr.Length + value.Length];
            arr.CopyTo(newArray, 0);

            for (int i = 0; i < value.Length; i++)
            {
                newArray[arr.Length + i] = value[i];}
            Console.WriteLine("new arr");
            foreach (int i in newArray)
            {
                Console.Write(i + " "); }
            newArray = arr;
                   
                     }
    }


}