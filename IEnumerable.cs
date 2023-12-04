/* IEnumerables are a basic interface that allow us to iterate (ie ask for one element at at time) from a collection or data sourcec. All collection types in C# inherit from this interface */

using System.Data;

int[] myArray = new int[] {1, 2, 3, 4, 5};
int[] myArray2 = {6, 7, 8, 9, 10};
int[] myArray3 = new int[5];

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(myArray3[i]);
}

for(int i = 1; i <= 5; i++)
{
    int j = 10;
    Console.WriteLine(i * j);
    myArray3[i - 1] = i * j;
}

IEnumerable<int> myArray3AsEnum = myArray3;

foreach(int item in myArray3AsEnum)
{
    Console.WriteLine(item);
}


/* We can assign the array to an IEnumerable because it implements the interface */ 
IEnumerable<int> myArrayAsEnumerable = myArray as IEnumerable<int>;
IEnumerable<int> myArrayAsEnum2 = myArray2;

/* we can use foreach */
// Console.WriteLine("using foreach on the array... ");
// foreach(int item in myArray)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("MyArray2 test");
// foreach(int item in myArray2)
// {
//     Console.WriteLine(item);
// }


/* Added this after executing the code from line 1 - 23. The IEnumerable refrences the array and IS NOT A COPY so the updated element for [0] displays within the output. */
// myArray[0] = 123;

// Console.WriteLine("Using foreach on the IEnumerable");
// foreach(int item in myArrayAsEnumerable)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("using myArray2 as IEnumerbale");
// foreach(int item in myArrayAsEnum2)
// {
//     Console.WriteLine(item);
// }



/* we cannot use for loops with indexing on IEnumerable! indexing is not support by IEnumerable, but it does work for arrays. */
// Console.WriteLine("using for loop on the array");
// for(int i = 0; i< myArray.Length; i++) 
// {
//     Console.WriteLine(myArray[i]);
// }

/* we cannot even get the length of the enumerable */
// for (int i = 0; i < myArrayAsEnumerable.Length; i++)
// {
//     //does not work
//     Console.WriteLine(myArrayAsEnumerable[i]);
// }