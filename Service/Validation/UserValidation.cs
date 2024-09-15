using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validation
{
    public class UserValidation
    {
        public static bool ValidationCreateUserModel(UserModel item)
        {
            var response = IsValidEmail(item.Email);
            return response;
        }


        public static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
