using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.IdentityNumber == 11111111111 &&
                gamer.FirstName == "ENGİN" && gamer.LastName == "DEMİROĞ")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
