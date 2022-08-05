using System.Text.RegularExpressions;

namespace System.ValidationsLibrary
{
    public static class Email
    {
        public static Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        public static bool isValid(string email)
        {
            Match checkEmail=regex.Match(email);   
            if(checkEmail.Success)
            {
                return true;
            }
            return false;
        }
    }
}