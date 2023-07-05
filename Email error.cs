using System;
namespace ConsoleApp10
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("Email address is short");
            }

            if (!email.EndsWith("@mail.com"))
            {
                throw new NotAnEmailAdressException("Invalid email address");
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emailValidator = new EmailValidator();

            try
            {
                bool isValid = emailValidator.Validate("ali.aliyev@mail.com");
                Console.WriteLine(isValid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
