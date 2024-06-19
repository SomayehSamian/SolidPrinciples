using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public class S_UserCreator
    {
        private readonly UserValidator _userValidator;
        private readonly UserRepostitory _userRepostitory;

        public S_UserCreator(UserValidator userValidator, UserRepostitory userRepostitory)
        {
            _userValidator = userValidator;
            _userRepostitory = userRepostitory;
        }
        public void CreateUser(string userName, string email, string password)
        {
            if (!_userValidator.ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format");
            }
            //bussines rules
            //database persistance
            _userRepostitory.SaveUserToDatabase(userName, email, password);
        }
    }

    public class UserValidator
    {
        public bool ValidateEmail(string email)
        {
            //validation logic
            return false;
        }
    }

    public class UserRepostitory
    {
        public void SaveUserToDatabase(string userName, string email, string password)
        {
            // database persistance logic
        }
    }

}
