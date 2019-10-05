using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class LevelModel {
    private static readonly LevelModel instance = new LevelModel();

    public Dictionary<int, Mission> missionList = new Dictionary<int, Mission>();

    static LevelModel() {

    }

    private LevelModel() {
        Mission simpleMission = new Mission(id: 0, name: "Beg", description: "To earn enough money to start you own adventurers guild, you decide to that begging in the streets is a good idea. Got to start somewhere I guess...", successChance: 0.95, goldReward: 10, difficulty: Mission.DifficultyType.Easy, metalReward: null, lumberReward: null, timer: 120, completed: false, successMessage: "Congratulations you managed to scrounge up some gold pieces off of some charitable citizens that have clearly done more with their lives that you. ", failureMessage: "While begging for money, your adventurer took an axe to the head for looking at looking at an angly Dwarf funny. Thier mother must be so proud.");
        missionList[simpleMission.ID] = simpleMission;
    }

    public static LevelModel Instance {
        get { return instance; }
    }
}
