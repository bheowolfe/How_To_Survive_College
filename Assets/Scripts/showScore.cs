using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class showScore : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    [SerializeField] Player script;
    [SerializeField] GameObject player;
    
    void Awake() {
        
        if(player == null) {
            player = GameObject.Find("Player");
            script = player.GetComponent<Player>();
        }
    }
    void Start()
    {
        score = GetComponent<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update()
    {
      string yourGrade;
        if (script.currentGrade <= 100 && script.currentGrade >= 90 ){
            yourGrade = "A";
        }
        else if (script.currentGrade <= 89 && script.currentGrade >= 80 ){
            yourGrade = "B";
        }
        else if (script.currentGrade <= 79 && script.currentGrade >= 70 ){
            yourGrade = "C";
        }
        else if (script.currentGrade <= 69 && script.currentGrade >= 60 ){
            yourGrade = "D";
        }
        else {
            yourGrade = "F";
        }
        // if(script.currentEnergy < 50)
        // {
        //     score.text = "your energy was low: "+ script.currentEnergy;
        // }
        // if(script.currentEnergy > 50)
        // {
        //     score.text = "your energy was high: "+ script.currentEnergy;
        // }
        score.text = "Health: " + script.currentHealth +"\nWealth: " + script.currentWealth +"\nEnergy: " + script.currentEnergy +"\nSocial: " + script.currentSocial + "\nKnowledge: " + script.currentAcademic +"\n\nYour overall happiness was: "  + script.currentHappiness + "\n and your grade for this semester was: " + yourGrade;
    }
}
