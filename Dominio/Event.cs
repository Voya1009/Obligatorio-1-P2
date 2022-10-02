using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Event
    {
        #region Attributes
        public enum EventType { Goal = 1, YellowCard = 2, RedCard = 3 };
        private EventType incident;
        private int minute;
        private Player player;
        #endregion

        #region Properties
        public EventType Incident { get => incident; set => incident = value; }
        public int Minute { get => minute; set => minute = value; }
        public Player Player { get => player; set => player = value; }
        #endregion

        #region Constructors        
        public Event(EventType incident, int minute, Player player)
        {
            this.incident = incident;
            this.minute = minute;
            this.player = player;
        }
        #endregion
        public bool Validate()
        {
            return true;
        }
    }
}