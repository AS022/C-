using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Ex11
    {//Super class or Base class or Parent Class
            static int no = 111;
            public Ex11()
            {
                AccountNo = no;
                no++;
                Balance = 5000;//Min Balance to open an Account
            }
            public int AccountNo { get; private set; }
            public string AccountHolder { get; set; }
            public double Balance { get; private set; }//only get is new in C# 6.0

            //Lambda Expression
            public void Credit(double amount) => Balance += amount;

            public void Debit(double amount)
            {
                if (amount > Balance)
                    throw new Exception("Insufficient Funds");
                else
                    Balance -= amount;
            }

        }
        //Derived class or sub class or child class will modify or add new functions to the base class
        class SBAccount : Ex11
        {
            //It inherits all the public, internal  and protected members into the current class..
            public void CalculateInterest()
            {
                double quarter = 0.25;
                double interestRate = 6.5 / 100;
                double interest = Balance * quarter * interestRate;
                Credit(interest);
            }
        }
        class InheritanceDemo
        {
            static void Main(string[] args)
            {
                Ex11 acc = new Ex11();

                SBAccount sb = new SBAccount();
                sb.AccountHolder = Console.getString("Enter the Name");
                sb.CalculateInterest();
                Console.WriteLine("The Current Balance: " + sb.Balance);

            }
        }

    }
/*
C# supports only one base class at any level(Single Inheritance).
The Base class functions can be modified in the derived class only if the base class version has a modifier called virtual. 
C# does not support private inheritance. It supports general inheritance. 
*/
