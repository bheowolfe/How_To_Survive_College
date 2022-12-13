using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExamScore : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    [SerializeField] Player script;
    [SerializeField] GameObject player;
    string examScore;
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
      
        if (script.currentAcademic <= 100 && script.currentAcademic >= 90 ){
            examScore = "95 on your first exam, that is better than 97% of the class";
            script.currentGrade += 15;
        }
        else if (script.currentAcademic <= 89 && script.currentAcademic >= 80 ){
            examScore = "85 on your first exam, that is better than average";
             script.currentGrade += 10;
        }
        else if (script.currentAcademic <= 79 && script.currentAcademic >= 70 ){
            examScore = "75 on your first exam, its okay but you could've done better";
             script.currentGrade += 5;
        }
        else if (script.currentAcademic <= 69 && script.currentAcademic >= 60 ){
            examScore = "65 on your first exam, that is not good, you need to study more";
            script.currentGrade -= 5;
        }
        else {
            examScore = "50 on your first exam, that's horrible you might have to drop the class";
             script.currentGrade -= 10;
        }
        
        score.text = "You scored a "+ examScore;
    }
}
