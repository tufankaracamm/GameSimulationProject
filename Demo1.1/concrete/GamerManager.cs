using Demo1._1.Abstarct;
using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.concrete
{
    public class GamerManager : GamerServices
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName+"Kişisi Silindi");
        }

        public void SignIn(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName+"Kişisi Giriş Yaptı");
        }

        public void SignOut(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + "Kişisi çıkış Yaptı");
        }

        public void SignUp(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + "Kişisi kayıt oldu");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + "Kişisi güncelledi");
        }
    }
}
