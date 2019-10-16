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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Scene_2");
        }
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Scene_3");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Scene_3");
    }


}
