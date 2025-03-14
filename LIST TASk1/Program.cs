using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LIST_TASk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection = ' ';
            List<int> list = new List<int>();

            do
            {
                Console.WriteLine("      ");
                Console.WriteLine("------------------");
                Console.WriteLine(" P - Print numbers ");
                Console.WriteLine(" A - Add a number ");
                Console.WriteLine(" M - Display mean of the numbers ");
                Console.WriteLine(" S - Display the smallest number ");
                Console.WriteLine(" L - Display the largest number ");
                Console.WriteLine(" C - To Clear the List ");
                Console.WriteLine(" F - To Find Index of Number");
                Console.WriteLine(" Q - Quit ");
                Console.WriteLine("------------------");

                Console.WriteLine("      ");
                Console.WriteLine("Please Enter your choice ");
                Console.WriteLine("      ");


                selection = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (selection == 'P')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"[] - the list is empty\"");
                        Console.WriteLine("      ");
                    }
                    else
                    {


                        Console.WriteLine("      ");
                        Console.Write("The List of Numbers is = ");
                        Console.Write("[");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write(" ");
                            Console.Write(list[i]);
                            Console.Write(" ");

                        }
                        Console.Write("]");

                    }
                }
                else if (selection == 'A')
                {
                    Console.WriteLine(" Please write number ");
                    int addList = Convert.ToInt32(Console.ReadLine());
                    if (addList % 1 == 0) ;
                    {
                        list.Add(addList);
                        Console.Write($"{addList} is added ");
                        Console.Write(" ");
                    }
                }
                else if (selection == 'M')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"Unable to calculate the mean - no data\"\r\n");
                    }
                    else
                    {
                        double sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        double mean = sum / list.Count;
                        Console.WriteLine($"The Mean is {mean}");

                    }

                }
                else if (selection == 'S')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"Unable to determine the largest number - list is empty\"\r\n");
                    }
                    else
                    {
                        int smallest = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i] < smallest)
                            {
                                smallest = list[i];
                            }

                        }
                        Console.WriteLine($"The Smallest number is : {smallest} ");
                    }

                }
                else if (selection == 'L')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"Unable to determine the largest number - list is empty\"");
                        Console.WriteLine("      ");
                    }
                    else
                    {
                        int largest = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i] > largest)
                            {
                                largest = list[i];
                            }

                        }
                        Console.WriteLine($"The Largest number is : {largest} ");
                    }

                }
                else if (selection == 'C')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"List is already Empty\"");
                        Console.WriteLine("      ");
                    }
                    else
                    {
                        list.Clear();
                    }
                    Console.WriteLine("      ");
                    Console.WriteLine("\"List is cleared\"");

                }
                else if (selection == 'F')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("      ");
                        Console.WriteLine("\"[] - the list is empty\"");
                        Console.WriteLine("      ");
                    }
                    else
                    {
                        Console.WriteLine("      ");
                        Console.Write("The List of Numbers is = ");
                        Console.Write("[");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write(" ");
                            Console.Write(list[i]);
                            Console.Write(" ");

                        }
                        Console.Write("]");
                        Console.WriteLine(" ");

                        Console.WriteLine("Please choose which number you want find his index ");
                        int target = Convert.ToInt32(Console.ReadLine());
                        int index = list.IndexOf(target);

                        if (index != -1)
                        {
                            Console.WriteLine("The index of the number " + target + " is: " + index);
                        }
                        else
                        {
                            Console.WriteLine("The number " + target + " is not in the list.");
                        }
                    }
                }

            } while (selection != 'Q');
            Console.WriteLine("Good Bye");
        }
    }
}
