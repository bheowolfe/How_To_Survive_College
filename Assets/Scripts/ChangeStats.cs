using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStats : MonoBehaviour
{
    [SerializeField] int health, wealth, energy, social, academic;
    [SerializeField] int happiness, grade;
    [SerializeField] GameObject healthBar, wealthBar, energyBar, socialBar, academicBar;
    // [SerializeField] GameObject answer;

    // Start is called before the first frame update
    void Start()
    {
        // retrieving reference to the game elements on the scene
        healthBar = GameObject.Find("StatusBars/Health bar");
        wealthBar = GameObject.Find("StatusBars/Wealth bar");
        energyBar = GameObject.Find("StatusBars/Energy bar");
        socialBar = GameObject.Find("StatusBars/Social bar");
        academicBar = GameObject.Find("StatusBars/Academic bar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateStat() {
        healthBar.GetComponent<Slider>().value += health;
        wealthBar.GetComponent<Slider>().value += wealth;
        energyBar.GetComponent<Slider>().value += energy;
        socialBar.GetComponent<Slider>().value += social;
        academicBar.GetComponent<Slider>().value += academic;
        Debug.Log("clicked");
    }
}
