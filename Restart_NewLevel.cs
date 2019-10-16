using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_NewLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame() //creates restart function for button
    {
        SceneManager.LoadScene("Scene_Game"); //loads game1 screen
        Debug.Log("You Restarted!"); //sends message to the console stating you restarted
    }
    public void NextLevel() //creates restart function for button
    {
        SceneManager.LoadScene("Scene_Game2"); //loads game2 screen
        Debug.Log("You Progressed!"); //sends message to the console stating you made progress
    }
}
