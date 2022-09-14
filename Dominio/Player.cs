using System;

namespace Dominio
{
    public class Player
    {
        #region Atributes
        private int id;
        private string name;
        private int number;
        private DateTime birthDate;
        private bool rightFoot;
        private int height;
        private int marketValue;
        public class Country { };
        public enum position { };
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public bool RightFoot { get => rightFoot; set => rightFoot = value; }
        public int Height { get => height; set => height = value; }
        public int MarketValue { get => marketValue; set => marketValue = value; }
        #endregion

        #region Constructors
        public Player(int id, string name, int number, DateTime birthDate, bool rightFoot, int height, int marketValue)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.birthDate = birthDate;
            this.rightFoot = rightFoot;
            this.height = height;
            this.marketValue = marketValue;
        }
        #endregion           
    }
}
