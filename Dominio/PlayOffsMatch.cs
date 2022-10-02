using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class PlayOffsMatch : Match
    {
        #region Attributes
        private bool extension;
        private bool penalties;
        public enum StageType { RoundOf16 = 1, Quarter = 2, Semi = 3, Final = 4 }
        private StageType stage;
        #endregion

        #region Properties               
        public bool Extension { get => extension; set => extension = value; }
        public bool Penalties { get => penalties; set => penalties = value; }
        public StageType Stage { get => stage; set => stage = value; }
        #endregion

        #region Constructors
        public PlayOffsMatch(Team localTeam, Team visitingTeam, DateTime expectedDate, bool extension, bool penalties, StageType stage) :
            base(localTeam, visitingTeam, expectedDate)
        {
            this.extension = extension;
            this.penalties = penalties;
            this.stage = stage;
        }

        public override void FinalizeMatch()
        {
            throw new NotImplementedException();
        }
        #endregion

        public bool Validate()
        {
            return true;
        }
    }


}
