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
        private List <Event> events;
        private string result;
        #endregion

        #region properties
        public int Id { get => id; }
        public Team LocalTeam { get => localTeam;  }
        public Team VisitingTeam { get => visitingTeam;  }
        public DateTime ExpectedDate { get => expectedDate;  }
        public bool HasEnded { get => hasEnded; set => hasEnded = value; }
        public string Result { get => result; set => result = value; }
        public List<Event> Events { get => events; }
        #endregion

        
        public Match(Team localTeam, Team visitingTeam, DateTime expectedDate)
        {
            this.id = ++counter;
            this.localTeam = localTeam;
            this.visitingTeam = visitingTeam;
            this.expectedDate = expectedDate;
            this.hasEnded = false;
            this.result = "pendiente";
            this.events = new List<Event>();
        }

        public abstract void FinalizeMatch();
        public void AddEvent(Event evt) {
            this.events.Add(evt);
        }

        #region Methods
        public Boolean Validate()
        {
            return true;
        }
        #endregion
    }
}
