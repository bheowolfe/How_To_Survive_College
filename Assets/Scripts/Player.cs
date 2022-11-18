using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int maxWealth = 100;
	public int maxEnergy = 100;
	public int maxSocial = 100;
	public int maxAcademic = 100;
	


	public int currentHealth;
	public int currentWealth;
	public int currentEnergy;
	public int currentSocial;
	public int currentAcademic;
	public int currentHappiness;
	public int currentGrade;
 
	public HealthBar healthBar;
	public WealthBar wealthBar;
	public EnergyBar energyBar;
	public SocialBar socialBar;
	public AcademicBar academicBar;

	public static Player Instance;

    // Start is called before the first frame update
	void Awake() {
		if(Instance == null) {
			DontDestroyOnLoad(this);
			Instance = this;
		}
		else
			Destroy(gameObject);
		currentHealth = maxHealth;
		currentWealth = maxWealth;
		currentEnergy = maxEnergy;
		currentSocial = maxSocial;
		currentAcademic = maxAcademic;
		

		healthBar.SetMaxHealth(maxHealth);	
		wealthBar.SetMaxWealth(maxWealth);
		energyBar.SetMaxEnergy(maxEnergy);
		socialBar.SetMaxSocial(maxSocial);
		academicBar.SetMaxAcademic(maxAcademic);
	}
    void Start()
    {
		// currentHealth = maxHealth;
		// currentWealth = maxWealth;
		// currentEnergy = maxEnergy;
		// currentSocial = maxSocial;
		// currentAcademic = maxAcademic;

		// healthBar.SetMaxHealth(maxHealth);	
		// wealthBar.SetMaxWealth(maxWealth);
		// energyBar.SetMaxEnergy(maxEnergy);
		// socialBar.SetMaxSocial(maxSocial);
		// academicBar.SetMaxAcademic(maxAcademic);
    }

    // Update is called once per frame
    void Update()
    {
		// if (Input.GetKeyDown(KeyCode.Space))
		// {
		// 	minusHealth(20);
		// }
    }

	void minusHealth(int damage)
	{
		// currentHealth -= damage;

		// healthBar.SetHealth(currentHealth);
	}
}
