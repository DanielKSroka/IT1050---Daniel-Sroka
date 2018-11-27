using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            public double getArea(double height, double width)
            {
                return height * width; }
            ///Scope shows where the method is called from. The scope is "public".
            ///A static method can be called without having to create another object in a class. Static methods do not depend on any data from any object. Non-static methods are called to operate on the data of specific objects. The method above is a non-static method.
            ///The return type is listed before the method name and defines the value returned on the method. The return type above is "double".
            ///The method name tells the code where to go to obtain info. The method name above is "getArea".
            ///Parameters tell the code if there are access restrictions. Public does not have restrictions but private does. The method above is public.
            ///The method body marks the area of code that must be executed. The method body above is width.

            ///A user defined method is written by the user and are hidden from other methods. Methods provided by the framework are able to be reused from several different locations in an application. When creating user-defined methods we should try to be concise and be sure that the code we create works.

            ///Static methods cannot have access to any non-static fields in an object, while non static methods can. Static methods are always preceded by static keywords.



    namespace Dog
    {
        class Dog
        {
            public string Name { get; set; }

            // Add bark() method

            public string bark;
            public static void bark();

            {
            Console.WriteLine( " {0} is Barking... " , Name ) ;
            }
        // Add doTrick() method

        public string doTrick;
        public static void doTrick(trickName);
    {
Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", name, trickName ) ; 
}
}

