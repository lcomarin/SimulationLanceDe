using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulateur_des
{
    public class Jeu
    {
        public Lancer Jet;
        public int Objectif;
        public String Condition;

        public Jeu(int obj, String cond, Lancer dernierJet)
        {
            Objectif = obj;
            Condition = cond;
            Jet = dernierJet;
        }

        public void ResultatJeu(){
            switch (Condition)
            {
                case "<":
                    if (Jet.resultat < Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé");
                    break;
                case "=":
                    if (Jet.resultat == Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé");
                    break;
                case ">":
                    if (Jet.resultat > Objectif)
                        MessageBox.Show("Jet réussi!");
                    else
                        MessageBox.Show("Echec du jet: Vous n'avez pas atteint l'objectif fixé");
                    break;
            }
        }

    }
}
