using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class ButtonLogic : MonoBehaviour
{
    public string location;
    public string level;
    public string difficulty;
    public TMPro.TMP_Dropdown locationDropdown;
    public TMPro.TMP_Dropdown levelDropdown;
    public TMPro.TMP_Dropdown difficultyDropdown;
    public JsonReader jsonReader;
    private Encounters encounterList;
    public TextMeshProUGUI textBox;
    

    void Start() 
    {
        locationDropdown.onValueChanged.AddListener(delegate { SetLocation(locationDropdown.options[locationDropdown.value].text); });
        levelDropdown.onValueChanged.AddListener(delegate { SetLevel(levelDropdown.options[levelDropdown.value].text); });
        difficultyDropdown.onValueChanged.AddListener(delegate { SetDifficulty(difficultyDropdown.options[difficultyDropdown.value].text); });

    }
    public void OnButtonPress()
    {

        encounterList = jsonReader.encounters;

        Debug.Log(encounterList);

        /*textBox.text = location + level + difficulty;
        Debug.Log(location + level + difficulty); */
    }



    public void SetLocation(string locations)
    {
        location = locations;
        //Debug.Log(location + level + difficulty);
    }
    public void SetLevel(string levels)
    {
        level = levels;
       //Debug.Log(location + level + difficulty);
    }
    public void SetDifficulty(string diff)
    {
        difficulty = diff;
        //Debug.Log(location + level + difficulty);
    }


}
