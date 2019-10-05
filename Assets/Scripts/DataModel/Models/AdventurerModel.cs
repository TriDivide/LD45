using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class AdventurerModel {

    
    private static readonly AdventurerModel instance = new AdventurerModel();

    public Dictionary<int, Adventurer> adventures = new Dictionary<int, Adventurer>();


    static AdventurerModel() {

    }

    private AdventurerModel() {
        Adventurer adventurer = new Adventurer(level: 1, id: 0, name: "Iron o'Brien", gender: Adventurer.GenderType.Male);

        adventures[adventurer.ID] = adventurer;
    }

    public static AdventurerModel Instance {
        get { return instance; }
    }
}
