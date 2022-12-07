using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
   [SerializeField] ChangeStats script;

   void Start() {
      script.UpdateBar();
   }
   public void LoadScene(string sceneName){
    SceneManager.LoadScene(sceneName);
   }
   public void conditionalLoadScene(string sceneName1, string sceneName2, string stat, int threshold){
	boolean s = false;
      if(stat == "Health"){
		if(Player.Instance.currentHealth >= threshold)
			s = True;}
	if(stat == "Wealth"){
		if(Player.Instance.currentWealth >= threshold)
			s = True;}
	if(stat == "Energy"){
		if(Player.Instance.currentEnergy >= threshold)
			s = True;}
	if(stat == "Social"){
		if(Player.Instance.currentSocial >= threshold)
			s = True;}
	if(stat == "Academic"){
		if(Player.Instance.currentAcademic >= threshold)
			s = True;}
	if(s)
		LoadScene(sceneName1);
	else
		LoadScene(sceneName2);
    
   public void QuitGame()
   {
      Application.Quit();
      Debug.Log("Quit!");
   }
}
