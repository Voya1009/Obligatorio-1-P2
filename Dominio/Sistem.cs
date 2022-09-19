using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Sistem
    {
        #region Attributes
        private static Sistem instance;
        private List<Country> countries = new List<Country>();
        private List<Team> teams = new List<Team>();
        #endregion

        #region Singleton
        public static Sistem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sistem();
                }
                return instance;
            }
        }
        #endregion

        #region Data Preload
        private Sistem()
        {

        }
        #endregion

        #region Properties
        public List<Country> Countries { get => countries; }
        public List<Team> Teams { get => teams; }
        #endregion

        #region Metods

        #endregion
    }
}
