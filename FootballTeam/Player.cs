using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    //public enum Position { Goalkeeper, Defender, Midfielder, Forward}
    class Player
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - DateOfBirth.Year;
                if(DateOfBirth.DayOfYear > DateTime.Now.DayOfYear)
                    _age--;
                    return _age;
            }
            
        }
    }
}
