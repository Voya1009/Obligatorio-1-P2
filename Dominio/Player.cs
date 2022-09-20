using System;

namespace Dominio
{
    public class Player
    {
        #region Atributes
        private int id;        
        private string number;
        private string name;
        private DateTime birthDate;        
        private double height;
        private string preferredFoot;
        private int marketValue;
        private string currencyType;        
        private Dominio.Country country;     
        private string position;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public double Height { get => height; set => height = value; }
        public int MarketValue { get => marketValue; set => marketValue = value; }
        public Country Country { get => country; set => country = value; }
        public string Position { get => position; set => position = value; }
        #endregion

        #region Constructors      
        public Player(int id, string number, string name, DateTime birthDate, double height, string preferedFoot, int marketValue, string currencyType, Country country, string position)
        {
            this.id = id;
            this.number = number;
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.preferredFoot = preferedFoot;
            this.marketValue = marketValue;            
            this.currencyType = currencyType;
            this.country = country;
            this.position = position;
        }
        #endregion
    }
}
