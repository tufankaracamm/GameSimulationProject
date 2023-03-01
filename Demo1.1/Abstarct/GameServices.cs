using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.Abstarct
{
    public interface GameServices
    {
         void add(Game game);
         void delete(Game game);
    }
}
