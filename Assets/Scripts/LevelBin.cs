using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelBin
{
    public LevelStateBin stateBin;

    public LevelBin(LevelStateBin bin)
    {
        stateBin = bin;
    }


}
