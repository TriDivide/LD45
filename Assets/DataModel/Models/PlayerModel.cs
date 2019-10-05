using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerModel {

    private static readonly PlayerModel instance = new PlayerModel();

    public Player player = new Player(gold:0, lumber:0, metal:0);
    static PlayerModel() {

    }

    private PlayerModel() {
    }

    public static PlayerModel Instance {
        get { return instance; }
    }
}
