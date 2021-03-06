using System;
using System.Collections;
using System.Collections.Generic;

namespace EL_BAHI_HASSAN
{
    class Stylo : Article
    {
        private string Color;

        public Stylo(string _nom, string _reference, double _prixUnitaire, string color):base(_nom, _reference, _prixUnitaire)
        {
            this.Color = color;   
        }
        public Stylo() : base(){}

        public bool Equals(Stylo stylo)
        {
            return (this.Color == stylo.Color);
        }

        public override string ToString()
        {
            return base.ToString() + $"Color {this.Color}";
        }
    }
}