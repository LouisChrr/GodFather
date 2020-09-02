using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Contient référence au Level de Bin
 * Contient une méthode déclenchée au démarrage du level
 * Contient une update du Level
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
    public abstract void StateUpdate();
    public abstract void StateUpdateState();


}
