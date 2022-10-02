using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Team : IValidate
    {
        #region Attributes
        private Country country;
        private List<Player> players = new List<Player>();
        #endregion

        #region Properties
        
        public List<Player> Players { get => players; set => players = value; }
        public Country Country { get => country; set => country = value; }
        #endregion

        #region Constructors
        public Team(Country country, List<Player> players)
        {
            this.country = country;
            this.players = players;            
        }
        #endregion

        #region Methods
        public Boolean Validate()
        {
            if (players.Count < 11 || country == null) return false;
            return true;
        }
        #endregion
    }
}
