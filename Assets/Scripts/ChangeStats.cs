using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStats : MonoBehaviour
{
    [SerializeField] int health = 0, wealth = 0, energy = 0, social = 0, academic = 0;
    [SerializeField] int happiness, grade;
    [SerializeField] GameObject healthBar, wealthBar, energyBar, socialBar, academicBar;
    [SerializeField] GameObject player;
    [SerializeField] Player script;
    // [SerializeField] GameObject answer;

    void Awake() {
        // retrieving reference to the game elements on the scene
        healthBar = GameObject.Find("StatusBars/Health bar");
        wealthBar = GameObject.Find("StatusBars/Wealth bar");
        energyBar = GameObject.Find("StatusBars/Energy bar");
        socialBar = GameObject.Find("StatusBars/Social bar");
        academicBar = GameObject.Find("StatusBars/Academic bar");

        if(player == null) {
            player = GameObject.Find("Player");
            script = player.GetComponent<Player>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // checks if it goes over or below the gauge min maxs
        if(health > script.currentHealth)
            script.currentHealth = 0;
        else if(health + script.currentHealth > 100)
            script.currentHealth = 100;
        if(wealth > script.currentWealth)
            script.currentWealth = 0;
        else if(wealth + script.currentWealth > 100)
            script.currentWealth = 100;
        if(energy > script.currentEnergy)
            script.currentEnergy = 0;
        else if(energy + script.currentEnergy > 100)
            script.currentEnergy = 100;
        if(social > script.currentSocial)
            script.currentSocial = 0;
        else if(social + script.currentSocial > 100)
            script.currentSocial = 100;
        if(academic > script.currentAcademic)
            script.currentAcademic = 0;
        else if(academic + script.currentAcademic > 100)
            script.currentAcademic = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateStat() {
        script.currentHealth += health;
        script.currentWealth += wealth;
        script.currentEnergy += energy;
        script.currentSocial += social;
        script.currentAcademic += academic;
        UpdateBar();
        Debug.Log("clicked");
    }
    public void UpdateBar() {
        healthBar.GetComponent<Slider>().value = script.currentHealth;
        wealthBar.GetComponent<Slider>().value = script.currentWealth;
        energyBar.GetComponent<Slider>().value = script.currentEnergy;
        socialBar.GetComponent<Slider>().value = script.currentSocial;
        academicBar.GetComponent<Slider>().value = script.currentAcademic;
    }
}
