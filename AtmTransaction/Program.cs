using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmTransaction
{
    class transaction
    {
        public void calc()
        {
            try
            {
                double amount;
                Console.WriteLine("Enter the account balance amount:");
                double balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 1 to withdraw and 2 to cancel withdrawal");
                int ch = 0;
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Enter the amount of money you want to withdraw");
                            amount = Convert.ToDouble(Console.ReadLine());
                            if (balance > amount)
                            {
                                if (amount % 5 == 0)
                                {
                                    balance = balance - amount - 0.5;
                                    Console.WriteLine("Remaining amount is {0}", balance);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please withdraw in multiples of 5");
                                    Console.WriteLine("Amount available is {0}", balance);
                                    break;
                                }
                            }
                            else
                                {
                                    Console.WriteLine("No sufficient amount available");
                                    Console.WriteLine("Amount available is {0}", balance);
                                    Console.ReadLine();
                                }
                            
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Your withdrawal is cancelled. Thankyou.");
                        }
                        break;


                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            transaction obj = new transaction();

            obj.calc();
        }
    }
}



