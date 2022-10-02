using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Country : IValidate
    {
        #region Atributes
        private string name;
        private string alphaThree;
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string AlphaThree { get => alphaThree; set => alphaThree = value; }
        #endregion

        #region Constructors
        public Country(string name, string alphaThree)
        {
            this.name = name;
            this.alphaThree = alphaThree;
            this.Validate();
        }
        #endregion

        #region Methods
        public Boolean Validate()
        {
            if (alphaThree.Length != 3 || name == null) return false;
            return true;
        }
        public override string ToString()
        {
            return $"Nombre: {Name}, AlphaThree: {AlphaThree}.";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Country c = (Country)obj;
            return c.Name.ToLower() == name.ToLower();
        }
        #endregion
    }
}
