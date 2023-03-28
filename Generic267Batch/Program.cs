using Generic267Batch;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Generics");
        Console.WriteLine("\nChoose any one options");
        Console.WriteLine("\n1:Delete Array Element");
        int options = Convert.ToInt32(Console.ReadLine());

        switch (options)
        {
            case 1:
                Console.WriteLine("\nChoose which data type element to delete");
                Console.WriteLine("\n1:Integer Array\n2:Double Array\n3:Char Array");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter the size of the array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];
                        Console.WriteLine("\nPlease enter element one by one");
                        for (int a = 0; a < arr.Length; a++)
                        {
                            arr[a] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("\nPick one element you want to delete");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("After deleting");
                        DeleteArrayClass.DeleteIntArrayMethod(arr, delete);
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the size of the array");
                        int size2 = Convert.ToInt32(Console.ReadLine());
                        double[] doubleArr = new double[size2];
                        Console.WriteLine("\nPlease enter element one by one");
                        for (int a = 0; a < doubleArr.Length; a++)
                        {
                            doubleArr[a] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("\nPick one element you want to delete");
                        double doubleDelete = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("After deleting");
                        DeleteArrayClass.DeletedDoubleArrayMethod(doubleArr, doubleDelete);
                        break;
                    case 3:
                        Console.WriteLine("\nEnter the size of the array");
                        int size3 = Convert.ToInt32(Console.ReadLine());
                        char[] charArr = new char[size3];
                        Console.WriteLine("\nPlease enter element one by one");
                        for (int a = 0; a < charArr.Length; a++)
                        {
                            charArr[a] = Convert.ToChar(Console.ReadLine());
                        }
                        Console.WriteLine("\nPick one element you want to delete");
                        char charDelete = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("After deleting");
                        DeleteArrayClass.DeletedCharArrayMethod(charArr, charDelete);
                        break;
                }
                break;

            default:
                Console.WriteLine("Please choose the any one options");
                break;
        }
        Console.ReadLine();
    }
}