using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName +", kaydınız başarıyla gerçekleştirilmiştir.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız olduğu için kayıt gerçekleştirilmedi.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + ", kaydınız başarıyla silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + ", kaydınız başarıyla güncellenmiştir.");
        }
    }
}
