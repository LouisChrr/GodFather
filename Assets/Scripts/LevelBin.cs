using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Contient référence au Level de Bin
 * Contient une méthode déclenchée au démarrage du level
 * Contient une update du Level
 * Est responsable du mouvement de la poubelle
 */
public abstract class LevelBin
{
    public LevelStateBin stateBin;

    public LevelBin(LevelStateBin bin)
    {
        stateBin = bin;
    }

    public abstract void StateBegin();
    public abstract void StateEnd();
    public abstract void LevelUpdate();
    public abstract void LevelUpdateState();
    public abstract void Move();

}
