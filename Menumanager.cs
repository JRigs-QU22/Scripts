using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if escape is pressed, load main menu
        {
            SceneManager.LoadScene("Scene_2");
        }
    }

    public void Credit()
    {
        SceneManager.LoadScene("Scene_Credits"); //creates function for button to go to credit screen
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Scene_3");
    }


}
