using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Country
    {
        #region Atributes
        private int id;
        private string name;
        private string alphaThree;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string AlphaThree { get => alphaThree; set => alphaThree = value; }
        #endregion

        #region Constructors
        public Country(int id, string name, string alphaThree)
        {
            this.id = id;
            this.name = name;
            this.alphaThree = alphaThree;
        }
        #endregion

        #region Metods
        #endregion
    }
}
