using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL_BAHI_HASSA
{
       abstract class Personne
       {
           protected int ID;
           protected string Nom;
           protected string Prenom;
           protected string E_mail;
           protected string Telephone;
           protected double Salaire;
           public abstract double  CalculeSalair();
       }
}