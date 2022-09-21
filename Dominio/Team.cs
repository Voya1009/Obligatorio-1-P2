using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Team
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
            this.Country = country;
            this.players = players;
        }
        #endregion
    }
}
