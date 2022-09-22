using System;//---using System means that we can use classes from the System namespac---//

namespace hello_world/*---namespace is used to organize your code, and it is a container
                      * for classes and other namespaces---*/
{
    class Program//---class is a container for data and methods, which brings functionality to your program---//
    {//---The curly braces {} marks the beginning and the end of a block of code.---//
        static void Main(string[] args)//---Main method. Any code inside its curly brackets {} will be executed---//
        {
            Console.WriteLine("Hello World!");/*Console is a class of the System namespace, which has a WriteLine() 
                                               method that is used to output/print text.*/
        }
    }
}
//Note: Every C# statement ends with a semicolon ; //
//Note: C# is case-sensitive: "MyClass" and "myclass" has different meaning//