using Demo1._1.Abstarct;
using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.concrete
{
    public class GameManager : GameServices
    {
        public void add(Game game)
        {
            Console.WriteLine("oyun eklendi");
        }

        public void delete(Game game)
        {
            Console.WriteLine("oyun silindi");
        }
    }
}
