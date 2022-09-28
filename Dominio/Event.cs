using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Event
    {
        public enum EventTipe { YELLOWCARD, REDCARD, GOAL };
        private int minute;
        private Player player;
        private EventTipe eventTipe;

        public Event(int minute, Player player, EventTipe eventTipe)
        {
            this.minute = minute;
            this.player = player;
            this.eventTipe = eventTipe;
        }

        public int Minute { get => minute; set => minute = value; }
        public Player Player { get => player; set => player = value; }
        public EventTipe EventTipe1 { get => eventTipe; set => eventTipe = value; }
    }
}
