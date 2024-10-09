using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Variable Declaration
            Int16 choice;
            Char Redo = 'n';

            while (Redo == 'n' || Redo == 'N')
            {

                //Display Title
                Console.Clear();
                Console.WriteLine("\t    NUMERIC CALCULATOR");
                Console.WriteLine("\tMain Menu Operators Choice");
                Console.WriteLine("\t---- ---- --------- ------\n");

                //Menu Options
                Console.Write("1 - ADDITION\n");
                Console.Write("2 - DIVISION\n");
                Console.Write("3 - MULTIPLICATION\n");
                Console.Write("4 - SUBSTRACTION\n");
                Console.Write("5 - QUIT\n");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt16(Console.ReadLine());

                //Loop: for choice
                while (choice < 1 || choice > 5)
                {
                    Console.Clear();
                    //Display Title
                    Console.WriteLine("\t    NUMERIC CALCULATOR");
                    Console.WriteLine("\tMain Menu Operators Choice");
                    Console.WriteLine("\t---- ---- --------- ------\n");

                    //Options
                    Console.Write("1 - ADDITION\n");
                    Console.Write("2 - DIVISION\n");
                    Console.Write("3 - MULTIPLICATION\n");
                    Console.Write("4 - SUBSTRACTION\n");
                    Console.Write("5 - QUIT\n");
                    Console.Write("Please enter a number (1 - 5): ");
                    choice = Convert.ToInt16(Console.ReadLine());
                }

                //Addition
                if (choice == 1)
                {
                    //Variable Declaration
                    Single[] tabAddition = new Single[10];
                    Single vSum;
                    Int16 VAdd;

                    //Loop: Number of values
                    do
                    {
                        do
                        {
                            Console.Clear();

                            //Display Title
                            Console.WriteLine("\tADDITION OPERATION");
                            Console.WriteLine("\t-------- ---------\n");

                            Console.Write("\nEnter the number of values to add (2 - 20): ");
                            VAdd = Convert.ToInt16(Console.ReadLine());

                        }
                        while (VAdd < 2 || VAdd > 20);

                        vSum = 0;
                        //Loop: Addition
                        for (Int16 i = 0; i < VAdd; i++)
                        {
                            Console.Write("Enter value " + (i + 1) + ": ");
                            tabAddition[i] = Convert.ToSingle(Console.ReadLine());

                            vSum += tabAddition[i];
                        }

                        Console.Write("\t    ------\n");
                        Console.Write("The Result is " + vSum);
                        Console.Write("\nDo you want another addition? (y/n): ");
                        Redo = Convert.ToChar(Console.ReadLine());
                    }
                    while (Redo == 'y' || Redo == 'Y');
                }
                //Divider
                else if (choice == 2)
                {
                    //Variable Declaration
                    float VDivide, VDivider, vDiv;

                    //Loop: Number of values
                    do
                    {
                        Console.Clear();

                        //Display Title
                        Console.WriteLine("\tDIVISION OPERATION");
                        Console.WriteLine("\t-------- ---------\n");

                        Console.Write("\nEnter the value to divide: ");
                        VDivide = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter the divider: ");
                        VDivider = Convert.ToSingle(Console.ReadLine());
                        while (VDivider == 0)
                        {
                            Console.Write("Enter the divider (different 0): ");
                            VDivider = Convert.ToSingle(Console.ReadLine());
                        }

                        vDiv = Convert.ToSingle(VDivide / VDivider);

                        Console.Write("\t    ------\n");
                        Console.Write("The Result is " + vDiv);
                        Console.Write("\nDo you want another division? (y/n): ");
                        Redo = Convert.ToChar(Console.ReadLine());
                    }
                    while (Redo == 'y' || Redo == 'Y');
                }
                //Multiplication
                else if (choice == 3)
                {
                    //Variable Declaration
                    Single[] tabMultiply = new Single[10];
                    Single VMult, vMult;

                    //Loop: Number of values
                    do
                    {
                        do
                        {
                            Console.Clear();

                            //Display Title
                            Console.WriteLine("\tMULTIPLICATION OPERATION");
                            Console.WriteLine("\t-------------- ---------\n");

                            Console.Write("\nEnter the number of values to add (2 - 20): ");
                            VMult = Convert.ToSingle(Console.ReadLine());

                        }
                        while (VMult < 2 || VMult > 20);

                        vMult = 1;
                        //Loop: Multiplication
                        for (Int16 i = 0; i < VMult; i++)
                        {
                            Console.Write("Enter value " + (i + 1) + ": ");
                            tabMultiply[i] = Convert.ToSingle(Console.ReadLine());

                            vMult *= tabMultiply[i];
                        }

                        Console.Write("\t    ------\n");
                        Console.Write("The Result is " + vMult);
                        Console.Write("\nDo you want another multiplication? (y/n): ");
                        Redo = Convert.ToChar(Console.ReadLine());
                    }
                    while (Redo == 'y' || Redo == 'Y');
                }
                //Subtraction
                else if (choice == 4)
                {
                    //Variable Declaration
                    Single VFirSub, VSecSub, vSubt;

                    //Loop: Number of values
                    do
                    {
                        Console.Clear();

                        //Display Title
                        Console.WriteLine("\tSUBTRACTION  OPERATION");
                        Console.WriteLine("\t----------- ---------\n");

                        Console.Write("\nEnter the first value: ");
                        VFirSub = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter the subtract: ");
                        VSecSub = Convert.ToSingle(Console.ReadLine());

                        vSubt = Convert.ToSingle(VFirSub - VSecSub);

                        Console.Write("\t    ------\n");
                        Console.Write("The Result is " + vSubt);
                        Console.Write("\nDo you want another substraction? (y/n): ");
                        Redo = Convert.ToChar(Console.ReadLine());
                    }
                    while (Redo == 'y' || Redo == 'Y');
                }
                //Quit
                else if (choice == 5 )
                {
                    Console.Write("Hasta la vista, baby! (º _ º)\n");
                    Redo = 'y';

                }
            }
        }
    }
}
