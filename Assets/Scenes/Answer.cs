using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    [SerializeField] string answer;
    [SerializeField] int health, wealth, energy, social, academic;
    [SerializeField] int happiness, grade;

    // public Answer(String answer, int health, int wealth, int energy, int social, int academic, int happiness, int grade) {
    //     this.answer = answer;
    //     this.health = health;
    //     this.wealth = wealth;
    //     this.energy = energy;
    //     this.social = social;
    //     this.academic = academic;
    //     this.happiness = happiness;
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
}
