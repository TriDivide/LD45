using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerModel {
    private static readonly AdventurerModel instance = new AdventurerModel();

    static AdventurerModel() {

    }

    private AdventurerModel() {

    }

    public static AdventurerModel Instance {
        get { return AdventurerModel; }
    }
}
