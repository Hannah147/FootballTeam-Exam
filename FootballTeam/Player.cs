using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    //public enum Position { Goalkeeper, Defender, Midfielder, Forward}
    public class Player:IComparable
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

        public Player(string firstName, string surname, Position position, DateTime dateofbirth)
        {
            FirstName = firstName;
            Surname = surname;
            Position = position;
            DateOfBirth = dateofbirth;
        }

        public Player()
        {

        }

        public override string ToString()
        {
            return $"{FirstName} {Surname} {(Age)} {Position}";
        }

        public int CompareTo(object other)
        {
            Player that = (Player)other;
            int returnValue = this.Position.CompareTo(that.Position);
            if(returnValue == 0)
            {
                returnValue = this.FirstName.CompareTo(that.FirstName);
            }
            return returnValue;
        }
    }
}
