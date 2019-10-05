using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Mission { 
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int SuccessChance { get; private set; }
    public int GoldReward { get; private set; }
    public int Difficulty { get; private set; }
    public int MetalReward { get; private set; }
    public int LumberReward { get; private set; }
    public float Timer { get; private set; }

}
