using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Team
    {
        #region Attributes
        private string country;
        private List<Player> players = new List<Player>();
        #endregion

        #region Properties
        public string Country { get => country; set => country = value; }
        public List<Player> Players { get => players; set => players = value; }
        #endregion

        #region Constructors
        public Team(string country, List<Player> players)
        {
            this.country = country;
            this.players = players;
        }
        #endregion
    }
}
