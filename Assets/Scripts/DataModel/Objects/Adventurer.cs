using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Adventurer {
    public int Level { get; set; }
    public int ID { get; private set; }
    public string Name { get; private set; }
    public GenderType Gender { get; private set; }

    // Add this when can be asked:
    // public EquipmentType Equipment { get; set; }

    public Adventurer(int level, int id, string name, GenderType gender) {
        this.Level = level;
        this.ID = id;
        this.Name = name;
        this.Gender = gender;
    }


    public enum GenderType {
        Male,
        Female,
    }
}
