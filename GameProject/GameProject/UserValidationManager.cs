using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "İrfan" && gamer.LastName == "Kahveci" && gamer.IdentyNumber == 123412)
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
