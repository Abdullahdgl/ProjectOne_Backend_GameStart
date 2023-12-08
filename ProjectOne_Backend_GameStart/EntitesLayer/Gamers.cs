using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne_Backend_GameStart.EntitesLayer
{
    public class Gamers:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirtday { get; set; }
        public string NationilityId { get; set; }


    }
}
