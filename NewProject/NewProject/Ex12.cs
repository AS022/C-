using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Method overriding is a feature of Inheritance where a method of a base class could be reimplemented in the derived class without altering its signature.
//In this case, the derived class retains its base class signature and allowed to implement it. 
//Only methods with virtual keyword could be overriden in the derived classes.
//The derived class will override the method using override keyword. Only virtual methods can be overriden in the derived class. However override methods can further be overriden in their derived classes.


namespace NewProject
{
    class Ex12
    {

        public virtual void SomeFunc()
        {
            Console.WriteLine("Base class function");
        }
    }

    class DerivedClass : Ex12
    {
        //2 ways: Retain the existing functionality and add few more...
        //Completely reimplement the functionality. 
        public override void SomeFunc()
        {
            base.SomeFunc();
            //base is the keyword in C# to represent the current class's immediate base class. 
            Console.WriteLine("adding few more features");
        }
    }
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            //Substitution principle...
            Ex12 instance = new DerivedClass();//Runtime polymorphism
            instance.SomeFunc();//It will invoke the derive version...
        }
    }
} 
   