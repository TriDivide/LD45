using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelModel {
    private static readonly LevelModel instance = new LevelModel();

    static LevelModel() {

    }

    private LevelModel() {

    }

    public static LevelModel Instance {
        get { return instance; }
    }
}
