/* IEnumerables are a basic interface that allow us to iterate (ie ask for one element at at time) from a collection or data sourcec. All collection types in C# inherit from this interface */

int[] myArray = new int[] {1, 2, 3, 4, 5};

/* We can assign the array to an IEnumerable because it implements the interface */ 
IEnumerable<int> myArrayAsEnumerable = myArray as IEnumerable<int>;

/* we can use foreach */
Console.WriteLine("using foreach on the array... ");
foreach(int item in myArray)
{
    Console.WriteLine(item);
}

Console.WriteLine("Using foreach on the IEnumerable");
foreach(int item in myArrayAsEnumerable)
{
    Console.WriteLine(item);
}

/* we cannot use for loops with indexing on IEnumerable! indexing is not support by IEnumerable, but it does work for arrays. */
// Console.WriteLine("using for loop on the array");
// for(int i = 0; i< myArray.Length; i++) 