using System;
using System.Text.RegularExpressions;


namespace Bank
{
    class Program
    {
        static int y;
        public static void debit(double c, float b)
        {
            double x = c + b;
            Console.WriteLine("Processing.... ");
            Console.WriteLine("Congrats, Amount debited");
            Console.WriteLine("Your updated balance is " + x);


        }
        public static void credit(double c, float b)
        {
            if (b > c)
            {

                double x = b - c;
                Console.WriteLine("Processing.... ");

                Console.WriteLine("Congrats, Amount cridted");
                Console.WriteLine("Your updated balance is " + x);
            }
            else
            {
                Console.WriteLine("Your balance is low , Rs." + b + "/-");
                Console.ReadKey();
            }
        }
        public static void pass(string a, string passx)
        {
            
            if (Regex.IsMatch(a, @"^[a-zA-Z]\w{3,14}$"))
            {
                if (a == passx)
                {
                    Console.WriteLine("Password Accepted.");
                    y = 1;
                }

                else
                {
                    Console.WriteLine("Invalid pass");
                    Console.ReadKey();
                    y = 0;
                }
            }
        }
    
        public static void bank()
        {
            Program p = new Program();
            int accnum, n, flag =1;
            string Name,s,password;
            float bal;
            double cred, deb;
            Console.Write("Welcome ! \n -------------------\n");
            Console.Write(" -------------------\n\n");
            Console.WriteLine("Enter Your Account Number: \n -------------------\n");
            accnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your  Full Name: \n-------------------\n");
            Name = Console.ReadLine();
            Random r = new Random();
            bal = r.Next(10500,20000);
            Console.WriteLine("Enter your bank Password");
            password = Console.ReadLine();
            Console.WriteLine("Your existing Balance is :"+ bal );
            Console.WriteLine("Remeber, Your min balance should be Rs.500");
        L1:
            Console.WriteLine("\n Enter the operation to be performed 1 or 2 \n 1. DEBIT \n 2.CREDIT  \n------------------ -\n");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Enter the Debit Amount");
                deb = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Password");
                s = Console.ReadLine();
                debit(deb,bal);
            }
            else
            {
                if (n == 2)
                {
                   
                    Console.WriteLine("Enter the Credit Amount");
                    cred = Convert.ToDouble(Console.ReadLine());
                    L2:
                    Console.WriteLine("Enter Password");
                    s = Console.ReadLine();
                   pass(s,password);
                    if (y == flag)
                    {
                        credit(cred, bal);
                    }
                    else
                    {
                        
                        
                        goto L2;
                    }
                }
                else
                {

                    Console.WriteLine("Invalid choice");
                    goto L1;
                }
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            bank();
        }
    }
}
