using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL_BAHI_HASSA
{
    class Devloper : Personne
    {
        private string Specialite;
        public Devloper() { }
        public Devloper(int id, string nom , string prenom, string e_mail, string tele, double salair, string specialite)
        {
            base.ID = id;
            base.Nom = nom;
            base.Prenom = prenom;
            base.E_mail = e_mail;
            base.Telephone = tele;
            base.Salaire = salair;
            this.Specialite = specialite;
        }

        public override double CalculeSalair()
        {
            return Salaire * 1.2;
        }

        public override string ToString()
        {
            return $" ID : {base.ID}\n name : {base.Nom}\n prenom : {base.Prenom}\n E_mail : {base.E_mail}\n Telephone : {base.Telephone}\n Salaire : {base.Salaire}\n Specialiter : {this.Specialite}\n Salaire : {this.CalculeSalair()}";
        }
    }
}