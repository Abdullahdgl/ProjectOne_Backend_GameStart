
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne_Backend_GameStart.EntitesLayer
{
    internal class Sale
    {
        public int Id { get; set; }
        public Gamers Gamers { get; set; }
        public Game Game { get; set; }
        public double Price { get { return Game.Price; }  }
        public DateTime SaleDate { get; set; }
    }
}
