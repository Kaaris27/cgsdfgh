using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LeagueSharp;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Game.Time == 1.00)
            {
                Game.PrintChat("test");
            }
        }
    }
}
