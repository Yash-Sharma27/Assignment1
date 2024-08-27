using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1 excecution");
            Que1 obj1 = new Que1();
            obj1.Q1();

            Console.WriteLine("Question 2 excecution");
            Que2 obj2 = new Que2();
            obj2.Q2();

            Console.WriteLine("Question 3 excecution");
            Que3 obj3 = new Que3();
            obj3.Q3();

            Console.WriteLine("Question 4 excecution");
            Que4 obj4 = new Que4();
            obj4.Q4();

            Console.WriteLine("Question 5 excecution");
            Que5 obj5 = new Que5();
            obj5.Q5();

            Console.WriteLine("Question 6 excecution");
            Que6 obj6 = new Que6();
            obj6.Q6();

            Console.WriteLine("Question 7 excecution");
            Que7 obj7 = new Que7();
            obj7.Q7();

            Console.WriteLine("Question 8 excecution");
            Que8 obj8 = new Que8();
            obj8.Q8();

            Console.WriteLine("Question 9 excecution");
            Que9 obj9 = new Que9();
            obj9.Q9();

            Console.WriteLine("Question 10 excecution");
            Que10 obj10 = new Que10();


            Console.ReadLine();
        }


    }

    public class Que1

    {
        public void Q1()
        {
            //number of items here 5
            int[] arr = new int[5];
            int i;
            double sum = 0;
            Console.WriteLine("Enter the prices below");
            for (i = 0; i < 5; i++)
            {
                Console.Write("item - {0} price: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            if (sum > 3000)
            {
                sum *= 0.1;
            }
            Console.WriteLine("Your total bill is : {0}", sum);
            Console.ReadLine();

        }
    }

    public class Que2
    {
        public void Q2()
        {
            int temp;
            double ferhen;
            Console.WriteLine("enter the temprature in C : ");
            temp = Console.Read();
            if (temp <= 0)
            {
                Console.WriteLine("Its freezing....");
            }
            else
            {
                ferhen = (9 / 5) * temp + 32;
                Console.WriteLine("Temperature in farhenhite is : ", ferhen);
            }

        }
    }

    public class Que3
    {
        public void Q3()
        {
            decimal balance = 0;

            Console.WriteLine("Welcome to the ATM Simulator!");

            while (true)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: ${balance}");
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: $");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine($"Deposit successful! New balance is: ${balance}");
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: $");
                        decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

                        if (withdrawal > balance)
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                        else
                        {
                            balance -= withdrawal;
                            Console.WriteLine($"Withdrawal successful! New balance is: ${balance}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting the ATM Simulator. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }


    public class Que4
    {
        public void Q4()
        {

            //average score of subjects
            float sum = 0;
            //float avg = 0;
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            for (int i = 0; i < scores.Length; i++)
            {
                sum = sum + scores[i];
            }
            float avg = sum / scores.Length;
            Console.WriteLine(avg);
            //Console.ReadLine();
            if (avg > 90)
            {
                Console.WriteLine("Your gearde is : A");
            }
            else if (avg > 80)
            {
                Console.WriteLine("Your grade is : B");
            }
            else if (avg > 70)
            {
                Console.WriteLine("Your grade is : C");
            }
            else if (avg > 50)
            {
                Console.WriteLine("Your grade is : D");
            }
            else
            {
                Console.WriteLine("Your Grade is : F");
            }
        }
    }

    public class Que5
    {
        public void Q5()
        {
            Console.WriteLine("Enter your password : ");
            string password = Console.ReadLine();
            if (password.Length > 8)
            {
                if (password.Any(char.IsUpper))
                {
                    if (password.Any(char.IsLower))
                    {
                        if (password.Any(char.IsDigit))
                        {
                            Console.WriteLine("password created succcessfully!");
                        }
                        else
                        {
                            Console.WriteLine("Lowercase charachter is missing!");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Uppercase character is missing!");
                }
            }
            else
            {
                Console.WriteLine("Your password is too short!");
            }
        }
    }



    public class Que6
    {
        public void Q6()
        {
            double fare = 1;
            Console.WriteLine("Please enter distance travelled : ");
            Console.Read();
            //Console.WriteLine("Using"
            TimeSpan start = new TimeSpan(10, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(12, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;
            fare *= 20;

            if ((now > start) && (now < end))
            {
                fare *= 5;
            }
            Console.WriteLine("Your total fare is : ", fare);
        }
    }



    public class Que7
    {
        public void Q7()
        {

            bool[] attendance = new bool[5];
            for (int i = 0; i < attendance.Length; i++)
            {
                Console.Write($"Is student present on day {i + 1}? (yes/no): ");
                attendance[i] = Console.ReadLine().ToLower() == "yes";
            }
            int daysAttended = 0;
            foreach (bool present in attendance)
            {
                if (present) daysAttended++;
            }
            Console.WriteLine($"Total Days Attended: {daysAttended}");
            if (daysAttended == 5)
            {
                Console.WriteLine("Perfect Attendance!");
            }
            Console.WriteLine();

        }
    }
    public class Que8
    {
        public void Q8()
        {
            double[] expenses = new double[12];
            double totalExpenses = 0;
            double maxExpense = double.MinValue;
            double minExpense = double.MaxValue;
            int maxMonth = 0;
            int minMonth = 0;

            for (int i = 0; i < expenses.Length; i++)
            {
                Console.Write($"Enter expenses for month {i + 1}: Rs. ");
                expenses[i] = Convert.ToDouble(Console.ReadLine());
                totalExpenses += expenses[i];
                if (expenses[i] > maxExpense)
                {
                    maxExpense = expenses[i];
                    maxMonth = i;
                }
                if (expenses[i] < minExpense)
                {
                    minExpense = expenses[i];
                    minMonth = i;
                }
            }
            Console.WriteLine($"Total Expenses for the Year: Rs. {totalExpenses}");
            Console.WriteLine($"Month with Highest Expense: {maxMonth + 1} (Rs. {maxExpense})");
            Console.WriteLine($"Month with Lowest Expense: {minMonth + 1} (Rs. {minExpense})\n");


        }
    }


    public class Que9
    {
        public void Q9()
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            cart.Add("Item1", 100);
            cart.Add("Item2", 200);
            cart.Add("Item3", 300);

            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. View Total Price");
            Console.Write("Choose an option (1-3): ");
            int cartOption = Convert.ToInt32(Console.ReadLine());

            switch (cartOption)
            {
                case 1:
                    Console.Write("Enter item name: ");
                    string addItem = Console.ReadLine();
                    Console.Write("Enter item price: Rs. ");
                    double addPrice = Convert.ToDouble(Console.ReadLine());
                    cart[addItem] = addPrice;
                    Console.WriteLine("Item added.");
                    break;
                case 2:
                    Console.Write("Enter item name to remove: ");
                    string removeItem = Console.ReadLine();
                    if (cart.ContainsKey(removeItem))
                    {
                        cart.Remove(removeItem);
                        Console.WriteLine("Item removed.");
                    }
                    else
                    {
                        Console.WriteLine("Item not found.");
                    }
                    break;
                case 3:
                    double totalCartPrice = 0;
                    foreach (var item in cart)
                    {
                        totalCartPrice += item.Value;
                    }
                    Console.WriteLine($"Total Price: Rs. {totalCartPrice}");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine();

        }
    }

    public class Que10
    {
        public Que10()
        {
            Console.Write("Enter the hourly wage: ");
            double hourlyWage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of hours worked in a week: ");
            double hoursWorkedInAWeek = Convert.ToDouble(Console.ReadLine());

            double monthlySalary = CalculateMonthlySalary(hourlyWage, hoursWorkedInAWeek);

            Console.WriteLine($"The monthly salary is: {monthlySalary:C}");
        }

        static double CalculateMonthlySalary(double hourlyWage, double hoursWorkedInAWeek)
        {
            const int weeksInAMonth = 4;
            return hourlyWage * hoursWorkedInAWeek * weeksInAMonth;
        }
    }
}