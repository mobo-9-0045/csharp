using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL_BAHI_HASSA
{
    class Manager : Personne
    {
        private string Service;
        public Manager(){}
        public Manager(int id, string nom , string prenom, string e_mail, string tele, double salair, string service)
        {
            base.ID = id;
            base.Nom = nom;
            base.Prenom = prenom;
            base.E_mail = e_mail;
            base.Telephone = tele;
            base.Salaire = salair;
            this.Service = service;
        }

        public override double CalculeSalair()
        {
            return Salaire * 1.35;
        }

        public override string ToString()
        {
        return $" id : {base.ID}\n name : {base.Nom}\n prenom : {base.Prenom}\n Email : {base.E_mail}\n Telephone{base.Telephone}\n salaire : {this.CalculeSalair()}\n service{this.Service}\n";
        }
    }
}