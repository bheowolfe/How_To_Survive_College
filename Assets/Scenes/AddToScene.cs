using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddToScene : MonoBehaviour
{
    [SerializeField] Text question;
    [SerializeField] TMP_Text[] answers;

    // Start is called before the first frame update
    void Start()
    {
        // string[] ans = {"ans0", "ans1"};
        Question q1 = new Question("Testing?", new string[] {"ans0", "ans1"});
        if(question == null) {
            question = GameObject.Find("Question").GetComponent<Text>();
        }
        question.text = q1.getQues(); 
        // retrieving all references to the answer boxes in the game
        int index = 0;
        if(answers.Length == 0) {
            GameObject[] temp = GameObject.FindGameObjectsWithTag("Answer");
            answers = new TMP_Text[temp.Length];
            foreach(GameObject g in temp) {
                answers[index] = temp[index++].GetComponent<TMP_Text>();
            }
            index = 0;
        }
        // taking the answers from the question to put into the text boxes
        foreach(string s in q1.getAnsArray()) {
            if(index > answers.Length) // making sure it doesn't try to place answers in answer boxes that don't exists
                break;
            else
                answers[index++].text = s;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
