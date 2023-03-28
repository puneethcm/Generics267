using Generic267Batch;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] charArray = { 'A', 'B', 'C', 'D' };
        int[] intArray = { 10, 20, 30, 50, 60 };
        double[] doubleArray = { 20.5, 30.6, 45.9, 56.7, 10.9 };
        Console.WriteLine("Welcome to Generics");
        Console.WriteLine("\nChoose any one options");
        Console.WriteLine("\n1:Delete Array Element\n2:Delete Array element By Generics Method concept\n3:Generic Class");
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

            case 2:
                //char[] charArray = { 'A','B','C','D' };
                //int[] intArray = { 10, 20, 30, 50, 60 };
                //double[] doubleArray = { 20.5, 30.6, 45.9, 56.7, 10.9 };

                DeleteArrayClass.Display<char>(charArray);
                Console.WriteLine("\nPick one element you want to delete");
                var deleteArray = Convert.ToChar(Console.ReadLine());
                DeleteArrayClass.DeleteGenericMethod<char>(charArray, deleteArray);
                Console.WriteLine("--------------------------------------------");
                DeleteArrayClass.Display<int>(intArray);
                Console.WriteLine("\nPick one element you want to delete");
                var deleteIntArray = Convert.ToInt32(Console.ReadLine());
                DeleteArrayClass.DeleteGenericMethod<int>(intArray, deleteIntArray);
                Console.WriteLine("--------------------------------------------");
                DeleteArrayClass.Display<double>(doubleArray);
                Console.WriteLine("\nPick one element you want to delete");
                var deleteDoubleArray = Convert.ToInt32(Console.ReadLine());
                DeleteArrayClass.DeleteGenericMethod<double>(doubleArray, deleteDoubleArray);

                break;
            case 3:
                DeleteArrayClass.Display<int>(intArray);
                Console.WriteLine("\nPick one element you want to delete");
                var intDelete2 = Convert.ToInt32(Console.ReadLine());
                GenericClass<int> intObj = new GenericClass<int>(intArray);
                intObj.DeleteArray(intArray, intDelete2);
                Console.WriteLine("--------------------------------------------");
                DeleteArrayClass.Display<double>(doubleArray);
                Console.WriteLine("\nPick one element you want to delete");
                var doubleDelete2 = Convert.ToDouble(Console.ReadLine());
                GenericClass<double> doubleObj = new GenericClass<double>(doubleArray);
                doubleObj.DeleteArray(doubleArray, doubleDelete2);
                Console.WriteLine("--------------------------------------------");
                DeleteArrayClass.Display<char>(charArray);
                Console.WriteLine("\nPick one element you want to delete");
                var charDelete2 = Convert.ToChar(Console.ReadLine());
                GenericClass<char> charObj = new GenericClass<char>(charArray);
                charObj.DeleteArray(charArray, charDelete2);

                break;

            default:
                Console.WriteLine("Please choose the any one options");
                break;
        }
        Console.ReadLine();
    }
}