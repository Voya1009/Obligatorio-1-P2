using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class GroupMatch : Match
    {
        public GroupMatch(Team localTeam, Team visitingTeam, DateTime expectedDate) : base(localTeam, visitingTeam, expectedDate)
        {
        }

        public override void FinalizeMatch()
        {
            throw new NotImplementedException();
        }
    }
}