using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definierar och initierar variabler.

            double total;              //Totalbeloppet
            double roundingOffAmount;  //Öresavrundning
            uint cash;                 //Kontant
            uint moneyBack;            //Tillbaka
            double subtotal;           //Subtotal

            //Användaren matar in priset

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumman     :");
                    total = double.Parse(Console.ReadLine());
                    break;
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Totalsumman är felaktig.");
                    Console.ResetColor();
                }
            } 

                if (total < 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Totalsumman är för låg.");
                    Console.ResetColor();
                    return;
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Ange erhållet belopp :");
                        cash = uint.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        break;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Erhållet belopp är felaktigt.");
                        Console.ResetColor();
                    }
                }
                    if (cash < total)
                    {


                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Beloppet är för lågt.");
                        Console.ResetColor();

                        return;
                    }

                    subtotal = (uint)Math.Round(total);
                    roundingOffAmount = total - subtotal;
                    moneyBack = cash - (uint)total;

                    //Kvitto
                    Console.WriteLine("KVITTO");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Totalt           :  {0:c}", total);
                    Console.WriteLine("Öresavrundning   :   -{0:c}", roundingOffAmount);
                    Console.WriteLine("Att betala       :     {0:c0}", (int)total);
                    Console.WriteLine("Kontant          :   {0:c0}", cash);
                    Console.WriteLine("Tillbaka         :     {0:c0}", moneyBack);
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(" ");

                    //Växelkassa

                    if (moneyBack >= 500)
                    {
                        Console.WriteLine("500-lappar :{0}", moneyBack / 500);
                        moneyBack %= 500;
                    }
                    if (moneyBack >= 100)
                    {
                        Console.WriteLine("100-lappar :{0}", moneyBack / 100);
                        moneyBack %= 100;
                    }
                    if (moneyBack >= 20)
                    {
                        Console.WriteLine(" 20-lappar :{0}", moneyBack / 20);
                        moneyBack %= 20;
                    }
                    if (moneyBack >= 5)
                    {
                        Console.WriteLine("  5-kronor :{0}", moneyBack / 5);
                        moneyBack %= 5;
                    }
                    if (moneyBack >= 1)
                    {
                        Console.WriteLine("  1-kronor :{0}", moneyBack / 1);
                    }


                
            }
        }
    }



