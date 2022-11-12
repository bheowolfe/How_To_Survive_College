using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] string question;
    [SerializeField] string[] answer;
    
    // Setting up a question object with all of its attributes
    public Question(string question, string[] answer) {
        this.question = question;
        List<string> tempList = new List<string>();
        foreach(string ans in answer) {
            tempList.Add(ans);
        }
        // Debug.Log("temp list: " + tempList.Count);
        this.answer = tempList.ToArray();
        // Debug.Log("ans array: " + answer.Length);
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // Universal getter for all the stats values
    // public int GetStats(string getter) {
    //     switch(getter)
    //     {
    //         case "health":
    //             return health;
    //             break;
    //         case "wealth":
    //             return wealth;
    //             break;
    //         case "energy":
    //             return energy;
    //             break;
    //         case "social":
    //             return social;
    //             break;
    //         case "academic":
    //             return academic;
    //             break;
    //         case "happiness":
    //             return happiness;
    //             break;
    //         case "grade":
    //             return grade;
    //             break;
    //         default:
    //             return -99; // placeholder value, our values should only range between 1-10 or something small
    //     }
    // }
    // get the question from the object
    public string getQues() {
        return question;
    }
    // get all the answers from the object
    public string[] getAnsArray() {
        return answer;
    }
}
