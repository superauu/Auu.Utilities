using System.Net.Mail;

namespace Auu.Utilities.String
{
    public static class Validator
    {
        public static bool IsEmailAddressValid(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}