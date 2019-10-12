/*
Author: Daniel Davidson
Date:   10/09/2019
CTEC 135: Microsoft Software Development with C# 

Module 2, Programming Assignment 1, Problem 3

    Prob 3: Decision Constructs

Create methods for each of the actions. Each method should contain a print statement 
with the text from the Actions part of the table as the output. Note: these methods 
are at the same level as the Main() method and should follow Main().

1. region 1 ( inside Main() ):
create 3 nested loops, one for each condition.
in the body of the inner-most loop
print a line stating the conditions. For example:
Conditions: prints: False, flashing light: False, printer recognized: False

use if statements to call the appropriate methods to print out the possible actions.
use vertical spacing as appropriate to make the output readable.

2. region 2 ( inside Main() ):
In a separate section of code implement a single for loop that iterates from 0 to 7. The programmer's trick here is to represent the condition values as a number. Using 0 for No and 1 for Yes, the conditions can be converted to a binary number. Use Printer prints as the most signicant bit, red light flashing as the next most significant, and so one. If all conditions are Yes, you get a binary number, 111 which translates to 7. Each column in the table above can be labeled with a number using this system.
In the loop body implement a switch statement that uses the iteration variable as its value. The code in each case will call the appropriate methods based on the number (column in the table).

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("\n---------For Loops---------\n");

            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                for (int redLightFlashingCondition = 0; redLightFlashingCondition <= 1; redLightFlashingCondition++)
                {
                    for (int printerRecognizedCondition = 0; printerRecognizedCondition <= 1; printerRecognizedCondition++)
                    {
                       
                        if (printerPrintsCondition == 0 && redLightFlashingCondition == 0 && printerRecognizedCondition == 0)
                        {
                            Console.WriteLine("Printer Prints: False, Red Light Flashing: False, Printer Recognized: False\n");
                            CheckThePrinterComputerCable();
                            EnsurePrinterSoftwareIsInstalled();
                            CheckReplaceInk();

                            // print out conditions 
                            /*
                            CheckPowerCable();
                            CheckThePrinterComputerCable();
                            EnsurePrinterSoftwareIsInstalled();
                            CheckReplaceInk();
                            CheckForPaperJam();
                            */


                        }
                        if (printerPrintsCondition == 0 && redLightFlashingCondition == 0 && printerRecognizedCondition == 1)
                        {
                            Console.WriteLine("Printer Prints: False, Red Light Flashing: False, Printer Recognized: True\n");
                            CheckReplaceInk();
                            CheckForPaperJam();
                            //call action methods
                            // printer jam
                            /*
                            printerPrintsCondition = 1;
                            redLightFlashingCondition = 0;
                            printerRecognizedCondition = 1;
                            */
                        }
                        if (printerPrintsCondition == 0 && redLightFlashingCondition == 1 && printerRecognizedCondition == 0)
                        {
                            Console.WriteLine("Printer Prints: False, Red Light Flashing: True, Printer Recognized: False\n");
                            CheckPowerCable();
                            CheckThePrinterComputerCable();
                            EnsurePrinterSoftwareIsInstalled();
                        }
                        if (printerPrintsCondition == 0 && redLightFlashingCondition == 1 && printerRecognizedCondition == 1)
                        {
                            Console.WriteLine("Printer Prints: False, Red Light Flashing: True, Printer Recognized: True\n");
                            CheckForPaperJam();
                        }
                        if (printerPrintsCondition == 1 && redLightFlashingCondition == 0 && printerRecognizedCondition == 0)
                        {
                            Console.WriteLine("Printer Prints: True, Red Light Flashing: False, Printer Recognized: False\n");
                            EnsurePrinterSoftwareIsInstalled();
                        }
                        if (printerPrintsCondition == 1 && redLightFlashingCondition == 0 && printerRecognizedCondition == 1)
                        {
                            Console.WriteLine("Printer Prints: True, Red Light Flashing: False, Printer Recognized: True\n");
                            CheckReplaceInk();
                        }
                        if (printerPrintsCondition == 1 && redLightFlashingCondition == 1 && printerRecognizedCondition == 0)
                        {
                            Console.WriteLine("Printer Prints: True, Red Light Flashing: True, Printer Recognized: False\n");
                            EnsurePrinterSoftwareIsInstalled();
                        }
                        if (printerPrintsCondition == 1 && redLightFlashingCondition == 1 && printerRecognizedCondition == 1)
                        {
                            Console.WriteLine("Printer Prints: True, Red Light Flashing: True, Printer Recognized: True\n");
                            Console.WriteLine("Nothing is wrong.");
                        }
                    }
                }

            }
            #endregion 1

            #region 2

            Console.WriteLine("\n---------Switch Statement---------\n");
            
            for (int i = 0; i < 7; i++)
            {

                switch (i)
                {
                    case 2:
                        CheckThePrinterComputerCable();
                        EnsurePrinterSoftwareIsInstalled();
                        CheckReplaceInk();
                        break;
                    case 3:
                        CheckThePrinterComputerCable();
                        EnsurePrinterSoftwareIsInstalled();
                        CheckReplaceInk();
                        break;
                    case 0:
                        CheckPowerCable();
                        CheckThePrinterComputerCable();
                        EnsurePrinterSoftwareIsInstalled();
                        break;
                    case 1:
                        CheckForPaperJam();
                        break;
                    case 6:
                        EnsurePrinterSoftwareIsInstalled();
                        break;
                    case 7:
                        CheckReplaceInk();
                        break;
                    case 4:
                        EnsurePrinterSoftwareIsInstalled();
                        break;
                    case 5:
                        Console.WriteLine("Why are you calling support?");
                        break;
                    default:
                        break;
                }

            }

            #endregion

        }

        // Methods 
        static void CheckPowerCable()
        {
            Console.WriteLine("Check power cable:");
        }

        static void CheckThePrinterComputerCable()
        {
            Console.WriteLine("Check the printer-computer cable:");
        }

        static void EnsurePrinterSoftwareIsInstalled()
        {
            Console.WriteLine("Ensure printer software is installed:");
        }

        static void CheckReplaceInk()
        {
            Console.WriteLine("Check/replace ink:");
        }

        static void CheckForPaperJam()
        {
            Console.WriteLine("Check for paper jam:");
        }
    }
}
        
    



