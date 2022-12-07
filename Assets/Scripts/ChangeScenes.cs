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
   public void QuitGame()
   {
      Application.Quit();
      Debug.Log("Quit!");
   }
}
