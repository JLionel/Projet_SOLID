using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{ 
    public void LoadScene(StringVariable scene)
    {
        SceneManager.LoadScene(scene.Value);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
