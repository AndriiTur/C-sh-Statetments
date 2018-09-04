using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sh_Statetments
{
    class Program
    {
        enum DrinkType { cofe = 0, tea = 1, juice = 2, water = 3 }

        static void Main(string[] args)
        {
            #region Task3_1
            //string firstDigitString;
            //string secondDigitString;
            //int firstDigit;
            //int secondDigit;
            //int count = 0;

            //Console.Write("Enter first digit: ");
            //firstDigitString = Console.ReadLine();
            //bool isDigitF = int.TryParse(firstDigitString, out firstDigit);

            //Console.Write("Enter second digit: ");
            //secondDigitString = Console.ReadLine();
            //bool isDigitS = int.TryParse(secondDigitString, out secondDigit);

            //if (isDigitF && isDigitS)
            //{
            //    for (int i = firstDigit; i <= secondDigit; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nYou ente not correct value");
            //}

            //Console.WriteLine($"\nCount digits from range[{firstDigit},{secondDigit}] divide by 3 = {count}");

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_2
            //string symbolsString;

            //Console.Write("Enter string of symbols: ");
            //symbolsString = Console.ReadLine();

            //for (int i = 1; i < symbolsString.Length; i+=2)
            //{
            //    Console.WriteLine($"\n{i} symbols is: {symbolsString[i]}");
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_3
            //string drinkName;

            //Console.Write("Enter drink name(coffe, tea, juice, water): ");
            //drinkName = Console.ReadLine();
            //drinkName = drinkName.ToLower();
            //switch (drinkName)
            //{
            //    case "coffe":
            //        Console.WriteLine($"\nYour choose \"{drinkName}\" it price: 10.0 grn");
            //        break;
            //    case "tea":
            //        Console.WriteLine($"\nYour choose \"{drinkName}\" it price: 6.0 grn");
            //        break;
            //    case "juice":
            //        Console.WriteLine($"\nYour choose \"{drinkName}\" it price: 8.0 grn");
            //        break;
            //    case "water":
            //        Console.WriteLine($"\nYour choose \"{drinkName}\" it price: 4.0 grn");
            //        break;
            //    default:
            //        Console.WriteLine($"\nYour \"{drinkName}\" not in the list");
            //        break;
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_4
            //string digitString;
            //int digit = 0;
            //int sum = 0;
            //int count = 0;
            //bool isDigit = true;

            //while (isDigit)
            //{
            //    Console.Write("Enter digit: ");
            //    digitString = Console.ReadLine();
            //    isDigit = int.TryParse(digitString, out digit);
            //    if (isDigit && digit >= 0)
            //    {
            //        sum += digit;
            //        count++;
            //    }
            //    else if(isDigit && digit < 0)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine($"\nDigits count: {count} \nDigits summ {sum} \nDigits average: {sum * 1/ count}");

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_5
            //string digitString;
            //int digit = 0;
            //bool isDigit;
            //bool isIntercalary;
            //string result;

            //Console.Write("Enter digit: ");
            //digitString = Console.ReadLine();
            //isDigit = int.TryParse(digitString, out digit);

            //if (isDigit && digit >=0 && digit <= 9999)
            //{
            //    isIntercalary = CheckYear(digit);
            //    if (isIntercalary)
            //    {
            //        Console.WriteLine($"\nEntered year {digit} is \"leap year\"");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nEntered year {digit} is \"not leap year\"");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nYou ente not correct year");
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_6
            //string digitString;
            //int digit = 0;
            //int digitTemp = 0;
            //bool isDigit;
            //int summ = 0;
            //Console.Write("Enter digit: ");
            //digitString = Console.ReadLine();
            //isDigit = int.TryParse(digitString, out digit);

            //if (isDigit)
            //{
            //    digitTemp = digit;
            //    while (digitTemp > 0)
            //    {
            //        int digN = digitTemp % 10;
            //        summ += digN;
            //        digitTemp = digitTemp / 10;
            //    }
            //    Console.WriteLine($"\nYou enter {digit} adition of digits = {summ}");
            //}
            //else
            //{
            //    Console.WriteLine("\nYou enter not correct value");
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task3_7
            //string digitString;
            //int digit = 0;
            //int digitTemp = 0;
            //bool isDigit;
            //bool isNotPair = false;

            //Console.Write("Enter digit: ");
            //digitString = Console.ReadLine();
            //isDigit = int.TryParse(digitString, out digit);

            //if (isDigit)
            //{
            //    digitTemp = digit;
            //    while (digitTemp > 0)
            //    {
            //        int digN = digitTemp % 10;
            //        if (digN % 2 != 0)
            //        {
            //            isNotPair = true;
            //        }
            //        digitTemp = digitTemp / 10;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nYou enter not correct value");
            //}

            //if (isNotPair)
            //{
            //    Console.WriteLine($"\nYou enter {digit} has nonpair digit(s)");
            //}
            //else
            //{
            //    Console.WriteLine($"\nYou enter {digit} in your digit are only pair digit(s)");
            //}


            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Homework3_A
            //string text;
            //int count = 0;

            //Console.Write("Enter text: ");
            //text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a' || text[i] == 'o' || text[i] == 'i' || text[i] == 'e')
            //    {
            //        count++;
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine("\nCount characters \"a\",\"o\",\"i\",\"e\" = {0}", count);

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Homework3_B
            //string monthStr;
            //bool isDigit;
            //int month;
            //int day;

            //Console.Write("Enter mounth(digit): ");
            //monthStr = Console.ReadLine();
            //isDigit = int.TryParse(monthStr, out month);

            //if (isDigit)
            //{
            //    day = GetDayInMonth(month);
            //    Console.WriteLine("\nDays in month {0}: {1}", month, day);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Homework3_C
            //string digitStr;
            //bool isDigit;
            //int digit;
            //int count = 0;
            //int summ = 0;
            //int pov = 1;

            //Console.WriteLine($"Enter 10 digit");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"\nEnter {i + 1} digit: ");
            //    digitStr = Console.ReadLine();
            //    isDigit = int.TryParse(digitStr, out digit);
            //    if (isDigit)
            //    {
            //        if (digit > 0 && i < 5)
            //        {
            //            summ += digit;
            //            count++;
            //        }
            //        else if (i >= 5)
            //        {
            //            pov *= digit;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nYou enter not correct value");
            //        Console.WriteLine("\nPress any key...");
            //        Console.ReadKey();
            //        return;
            //    }
            //}

            //if (count == 5)
            //{
            //    Console.WriteLine($"\nSumm first fives digits = {summ}");
            //}
            //else
            //{
            //    Console.WriteLine($"\nPov las fives digits = {pov}");
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion
        }

        private static int GetDayInMonth(int month)
        {
            return DateTime.DaysInMonth(DateTime.Now.Year, month);
        }

        private static bool CheckYear(int digit)
        {
            if (digit % 400 == 0)
            {
                return true;
            }
            else if (digit % 4 == 0 && digit % 100 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
