using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.Abstarct
{
    public interface GamerServices
    {
         void SignUp(Gamer gamer);
         void SignIn(Gamer gamer);
         void SignOut(Gamer gamer);
         void Update(Gamer gamer);
         void Delete(Gamer gamer);
    }
}
