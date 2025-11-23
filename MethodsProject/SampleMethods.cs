using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsProject;
//access modifies are not about permissions

//internal = anyone on this project may use this
//private = anyone within the scope can use this
public static class SampleMethods
{

    public static void Welcome()
    {
        Console.WriteLine("Welcome to the application where I am learning methods!");
    }
    //public static void SayHi() //This is the method signature
    //{//curly braces define the method body or the scope
    //    //Name it whatever you want, but ensure to use Pascal Casing with open/closing parentheses
    //    Console.WriteLine("Hello, Learner!");
    //    Console.WriteLine("I hope you are having a good day!");
    //    //this isn't RETURNING anything, its performing an aciton
    //}
}


    //originally was internal class SampleMethods
    //changed it to make a call directly to the method
    //without having to set anything up
    //which is instantiaiton

