using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public class BeforeUserCreator
    {
        public void CreateUser(string userName, string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format");
            }
            //bussines rules
            //database persistance
            SaveUserToDatabase(userName, email, password);
        }
        private bool ValidateEmail(string email)
        {
            //validation logic
            return false;
        }
        private void SaveUserToDatabase(string userName, string email, string password)
        { 
           // database persistance logic
        }
    }
}
