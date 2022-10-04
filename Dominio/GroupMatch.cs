using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class GroupMatch : Match
    {
        public enum Groups { A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8 }
        private Groups group;

        public Groups Group { get => group; set => group = value; }

        public GroupMatch(Team localTeam, Team visitingTeam, DateTime expectedDate, Groups group) :
            base(localTeam, visitingTeam, expectedDate)
        {
            this.group = group;
        }
        public GroupMatch() : base()
        {

        }

        public override void FinalizeMatch()
        {
            throw new NotImplementedException();
        }        
    }
}