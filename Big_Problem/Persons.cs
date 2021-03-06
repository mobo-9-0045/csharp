using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace TP5
{
    class Personne
    {
        int code;
        String nom;
        String prenom;
        int age;
        // Constructeurs
        public Personne() { }
        public Personne(String nom, String prenom, int age, int code)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.code = code;
        }
        // les accesseurs et mutateurs
        public int getCode()
        {
           return code; 
             
        }
        public void setCode(int _code) {
             code = _code; 
        }
        public int getAge()
        {
            return age;
 
        }
        public void setAge(int _age)
        {
            age = _age;
        }
        public string getNom()
        {
            return nom;
 
        }
        public void setNom(string _nom)
        {
            nom = _nom;
        }
        public string getPrenom()
        {
            return prenom;
 
        }
        public void setPrenom(string _prenom)
        {
            prenom = _prenom;
        }
        // Question 3
        public String getinfo()
        {
            return " Je m’appelle " + nom + " -- " + prenom + " J’ai " + age + " an j'ai le code " + code;
        }
        // Question 4 : déclaration de la liste des personnes
        static List<Personne> lis = new List<Personne>();
 
 
        // Question 5
        static public void ajouter(Personne p)
        {
            lis.Add(p);
        }
 
        // Question 6
        static public void modifier_nom(int c, String n)
        {
            foreach (Personne p in lis)
            {
                if (p.code == c)
                {
                    p.nom = n;
                }
            }
        }
         
        // Question 7
        static public void supprimer(String n) { 
            foreach (Personne p in lis) {
                if (p.nom.Equals(n)) { 
                    lis.Remove(p);
                    break; 
                } 
            }
        }
        // Question 8
        static public Personne chercher(int code)
        {
            Personne pr = null;
            foreach (Personne p in lis)
            {
                if (p.code == code)
                {
                    pr = p; 
                    break;
                }
            } return pr;
        }
        // Question 9
        static public void affichage()
        {
            foreach (Personne p in lis)
            {
                Console.WriteLine(p.getinfo());
            }
        }
        // Question 10
        static public int compter()
        {
            return lis.Count;
        }
        // Question 11
        static public void categories()
        {
            foreach (Personne p in lis)
            {
                if (p.age <= 18) {
                    Console.WriteLine("la catégorie de " + p.nom + " est :P");
                }
                if (p.age >= 19 && p.age <= 35) {
                    Console.WriteLine("la catégorie de " + p.nom + " est :J");
                }
                if (p.age >= 36) {
                    Console.WriteLine("la catégorie de " + p.nom + " est :G");
                }
            }
        }
    }   
}