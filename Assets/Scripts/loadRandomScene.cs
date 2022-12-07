using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadRandomScene : MonoBehaviour
{
    public void LoadRandomScene()
    {
        int index = Random.Range(42,46);
        SceneManager.LoadScene(index);
    }
}
