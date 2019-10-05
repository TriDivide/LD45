using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Mission { 
    public string Name { get; private set; }
    public string Description { get; private set; }
    public float SuccessChance { get; private set; }
    public int? GoldReward { get; private set; }
    public DifficultyType Difficulty { get; private set; }
    public int? MetalReward { get; private set; }
    public int? LumberReward { get; private set; }
    public float Timer { get; private set; }
    public int ID { get; private set; }
    public bool Completed { get; set; }

    public Adventurer? assignedAdventurer { get; set; }

    public string SuccessMessage { get; private set; }
    public string FailureMessage { get; private set; }

    public Mission(int id, string name, string description, float successChance, 
        int? goldReward, DifficultyType difficulty, int? metalReward, int? lumberReward, 
        float timer, bool completed, string successMessage, string failureMessage) {

        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.SuccessChance = successChance;
        this.GoldReward = goldReward;
        this.Difficulty = difficulty;
        this.MetalReward = metalReward;
        this.LumberReward = lumberReward;
        this.Timer = timer;
        this.Completed = completed;
        this.SuccessMessage = successMessage;
        this.FailureMessage = failureMessage;
        this.assignedAdventurer = null;
    }

    public enum DifficultyType {
        Easy,
        Medium,
        Hard,
        Insane
    }
}

static class DifficultyMethods {
    public static string toString(this Mission.DifficultyType d1) {
        switch (d1) {
            case Mission.DifficultyType.Easy:
                return "Easy";

            case Mission.DifficultyType.Medium:
                return "Medium";
            case Mission.DifficultyType.Hard:
                return "Hard";
            case Mission.DifficultyType.Insane:
                return "Insane";
            default:
                return "";
        }
    }
}


