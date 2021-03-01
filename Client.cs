using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Client
    {
        
        private readonly string name;
        private readonly string prenom;
        private readonly string adress;

        public Client(string name, string prenom, string adress)
        {
            this.name = name;
            this.prenom = prenom;
            this.adress = adress;
        }


        public void Afficher()
        {
            Console.WriteLine("Le nom du client : \t " + this.name);
            Console.WriteLine("Le prénom du client : \t " + this.prenom);
            Console.WriteLine("Votre adresse : \t " + this.adress);
        }
    }

}
    
