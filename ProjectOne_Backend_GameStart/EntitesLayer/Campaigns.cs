using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne_Backend_GameStart.EntitesLayer
{
    public class Campaigns : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }


    }
}
