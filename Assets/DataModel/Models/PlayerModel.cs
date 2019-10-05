using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerModel {

    private static readonly PlayerModel instance = new PlayerModel();

    static PlayerModel() {

    }

    private PlayerModel() {

    }

    public static PlayerModel Instance {
        get { return instance; }
    }
}
