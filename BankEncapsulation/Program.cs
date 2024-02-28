namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                BankAccount account = new BankAccount();


                Console.WriteLine("Welcome to the Bank!");
                while (true)
                {
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Check Balance");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter the amount to deposit: ");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(depositAmount);
                            Console.WriteLine("Deposit successful!");
                            break;
                        case "2":
                            Console.WriteLine($"Your current balance is: {account.GetBalance()}");
                            break;
                        case "3":
                            Console.WriteLine("Thank you for banking with us!");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
