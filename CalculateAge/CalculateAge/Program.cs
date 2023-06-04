namespace CalculateAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yyour date of birth (yyyy/mm/dd) : ");
            string input = Console.ReadLine();

            DateTime dateOfBirth;
            if(DateTime.TryParse(input, out dateOfBirth))
            {
                int age = CalculateAge(dateOfBirth);
                Console.WriteLine($"Your age is : {age} years");
            }
            else
            {
                Console.WriteLine("invalid date format");
            }
            Main(args);
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Month > today.Month || 
                (dateOfBirth.Month == today.Month && 
                dateOfBirth.Day > today.Day))
            {
                age--;
            }
            return age;
        }
    }
}