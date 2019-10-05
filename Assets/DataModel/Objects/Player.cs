using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Player {
    public int Gold { get; set; }
    public int Lumber { get; set; }
    public int Metal { get; set; }


    public Player(int gold, int lumber, int metal) {
        this.Gold = gold;
        this.Lumber = lumber;
        this.Metal = metal;
    }
}

