using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SocialScore : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    [SerializeField] Player script;
    [SerializeField] GameObject player;
    string socialScore;
    
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
      
        if (script.currentSocial <= 100 && script.currentSocial >= 50 ){
            socialScore = " everybody in the party liked you";
            script.currentHappiness += 10;
        }
        
        else if (script.currentSocial <= 49 && script.currentSocial >= 1 ){
            socialScore = " you didn't know how to talk to people and was quite awkward";
           script.currentHappiness -= 10;
        }
        
        score.text = "You had a social score of "+ script.currentSocial+ socialScore;
    }
}
