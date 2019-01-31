using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeDés
{

    /// <summary>
    /// Classe qui représente un dé à jouer.
    /// À la création, le nombre de faces est ajustable.
    /// </summary>
    class Dé
    {
        // Attributs
        private int nbreFaces;
        private int faceVisible = 1;
        private static Random générateurPseudoAléatoire = new Random();

        //Mise en place de la propriété face visible
        public int FaceVisible
        {
            get
            {
                return faceVisible;
            }

            set
            {
                if (value >= 1 && value <= nbreFaces)
                {
                    faceVisible = value;
                }
            }
        }

        /// <summary>
        /// Construit un dé selon les caractéristiques
        /// données.
        /// </summary>
        /// <param name="nbreFaces">Nombre de faces du dé.</param>
        /// <param name="faceVisible">Numéro de la face visible.</param>
        public Dé(int nbreFaces = 6, int faceVisible = 1)
        {
            if (nbreFaces < 1)
                nbreFaces = 1;

            this.nbreFaces = nbreFaces;
            ChoisirFaceVisible(faceVisible);
        }

        /// <summary>
        /// Récupère le numéro de la face visible.
        /// </summary>
        /// <returns>la face visible.</returns>
        public int LireFaceVisible()
        {
            return faceVisible;
        }

        /// <summary>
        /// Jete le dé.
        /// </summary>
        public void Jeter()
        {
            faceVisible = générateurPseudoAléatoire.Next(1, nbreFaces + 1);
        }

        /// <summary>
        /// Change la face visible du dé, pour autant que
        /// la face voulue soit valide.
        /// </summary>
        /// <param name="faceVoulue">Face que doit présenter le dé.</param>
        public void ChoisirFaceVisible(int faceVoulue)
        {
            if (faceVoulue >= 1 && faceVoulue <= nbreFaces)
            {
                faceVisible = faceVoulue;
            }
        }
        /// <summary>
        /// Vérifie si ce dé est identique au dé passé en paramètre.
        /// </summary>
        /// <param name="autreDé"></param>
        /// <returns>vrai si identique, sinon faux</returns>
        public bool Comparer(Dé autreDé)
        {
            return (nbreFaces == autreDé.nbreFaces &&
                faceVisible == autreDé.faceVisible);
        }


    }
}
