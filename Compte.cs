using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Compte
    {
       
            private int mat;
            private double solde;
            private Client titulaire;
            private static int nb= 0;


            public Compte(Client titulaire, double solde)
            {
                nb++;
                this.mat = nb;
                this.solde = solde;
                this.titulaire = titulaire;
            }

            public void Crediter(double sum)
            {
                if (sum > 0)
                {
                    this.solde += sum;
                    Console.WriteLine("Vous avez crédité une somme de :" + sum);
                }
                else
                {
                    Console.WriteLine("La somme est litéralement positive");
                }

            }


            public void Debiter(double sum)
            {
                if (this.solde >= sum)
                {
                    this.solde -= sum;
                    Console.WriteLine("Vous avez fait un retrait de :" + sum);
                }
                else
                {
                    Console.WriteLine("Solde complétement insuffisant !");
                }

            }


            public void Afficher()
            {
                Console.WriteLine("Numéro du Compte est : \t " + this.mat);
                Console.WriteLine("Solde du compte est : \t" + this.solde + " MAD");
                Console.WriteLine("Titulaire du compte est : \t ");

                titulaire.Afficher();
            }


        }
    }
