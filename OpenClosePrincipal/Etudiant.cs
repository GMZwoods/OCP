using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Classes { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }

        public Etudiant(string nom, string prenom, string classe, int age, string sexe) 
        {
            Nom = nom;
            Prenom = prenom;
            Classes = classe;
            Age = age;
            Sexe = sexe;            
        }

        public List<Etudiant> etudiantAFiltrer = new List<Etudiant> { };
        public override string ToString()
        {
            return "Nom : " + Nom + "\n" + " Prénom : " + Prenom + "\n" + "Classes : " + Classes + "\n" + "Âge : " + Age + "\n";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Etudiant)) return false;
            Etudiant e = (Etudiant)obj;
            return Nom == e.Nom && Prenom == e.Prenom && Classes == e.Classes && Age == e.Age && Sexe == e.Sexe;
        }
    }
}
