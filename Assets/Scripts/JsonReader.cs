using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public Encounters encounters;
    public TextAsset jsonFile;
    void Start() {
      
        encounters = JsonUtility.FromJson<Encounters>(jsonFile.text);

    }
     /*public Encounter generateEncounter(string location, string level, string difficulty) {

        List<Encounter> toReturnEncounter = new List<Encounter>();
        int i = 0;
        string locationSet = location;
        string levelSet = level;
        string difficultySet = difficulty;
        foreach (Encounter e in encounters.encounters)
        {
            toReturnEncounter[i] = e;
            i++;
        }


        return toReturnEncounter;
    }*/
}
