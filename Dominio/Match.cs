using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Match : IValidate
    {
        #region Atributes
        private static int counter = 0;
        private int id;
        private Team localTeam;
        private Team visitingTeam;
        private DateTime expectedDate;
        private Boolean hasEnded;
        private List<Event> events = new List<Event>();
        private string result;
        #endregion

        #region properties
        public int Id { get => id; set => id = value; }
        public Team LocalTeam { get => localTeam; set => localTeam = value; }
        public Team VisitingTeam { get => visitingTeam; set => visitingTeam = value; }
        public DateTime ExpectedDate { get => expectedDate; set => expectedDate = value; }
        public bool HasEnded { get => hasEnded; set => hasEnded = value; }
        public List<Event> Events { get => events; set => events = value; }
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
            this.events = new List<Event>();
            this.result = "pendiente";
            this.Validate();
        }

        public abstract void finalizeMatch();
        #endregion

        #region Methods
        public Boolean Validate()
        {
            if (localTeam == null || visitingTeam == null) return false;
            if (expectedDate < DateTime.Parse("20/11/2022") || expectedDate > DateTime.Parse("18/12/2022")) return false;
            return true;
        }
        #endregion
    }
}
