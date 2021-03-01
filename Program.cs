using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client("Benchama","Oussama","Rue 14");
            Client C2 = new Client("Rezouki", "Rachid", "Rue 17");
            C1.Afficher();
            C2.Afficher();
            Compte C3 = new Compte(C1, 1000);
            Compte C4 = new Compte(C2, 2000);
            C3.Afficher();
            C4.Afficher();
            C3.Debiter(400);
            C4.Debiter(300);
            C3.Crediter(4000);
            C4.Crediter(5000);

        }
    }
}