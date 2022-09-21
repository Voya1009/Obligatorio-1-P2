using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Country
    {
        #region Atributes
        private string name;
        private string alphaThree;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string AlphaThree { get => alphaThree; set => alphaThree = value; }
        #endregion

        #region Constructors
        public Country(string name, string alphaThree)
        {
            this.name = name;
            this.alphaThree = alphaThree;
        }
        #endregion

        #region Methods
        public Boolean Validate()
        {
            return true;
        }
        #endregion
    }
}
