using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Contient référence à la poubelle
 * Contient une méthode pour enregistrer un nouveau niveau
 * Contient une méthode pour passer d'un niveau à l'autre
 * Met à jour le niveau en cours
 */


public class LevelStateBin
{

    public LevelBin bin;
    public int level;
    public LevelBin currentLevel;

    public LevelStateBin(Bin poubelle)
    {
        bin = poubelle;
    }
}
