using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Match
    {
        #region Atributes
        private static int counter = 0;
        private int id;
        private Team localTeam;
        private Team visitingTeam;
        private DateTime expectedDate;
        private Boolean hasEnded;
        //event list
        private string result;
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public Team LocalTeam { get => localTeam; set => localTeam = value; }
        public Team VisitingTeam { get => visitingTeam; set => visitingTeam = value; }
        public DateTime ExpectedDate { get => expectedDate; set => expectedDate = value; }
        public bool HasEnded { get => hasEnded; set => hasEnded = value; }
        public string Result { get => result; set => result = value; }
        #endregion

        #region Constructors
        public Match(Team localTeam, Team visitingTeam, DateTime expectedDate)
        {
            this.id = ++counter;
            this.localTeam = localTeam;
            this.visitingTeam = visitingTeam;
            this.expectedDate = expectedDate;
            this.hasEnded = false;
            this.result = "pendiente";
        }

        public abstract void finalizeMatch();
        #endregion

        #region Methods
        public Boolean Validate()
        {
            return true;
        }
        #endregion
    }
}
