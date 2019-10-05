using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Adventurer {
    public int Level { get; set; }
    public string Name { get; private set; }
    public GenderType Gender { get; private set; }

    // Add this when can be asked:
    // public EquipmentType Equipment { get; set; }



    public enum GenderType {
        Male,
        Female,
    }
}
