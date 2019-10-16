using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if you press escape load main menu
        {
            SceneManager.LoadScene("Scene_2");
        }
        if (Input.GetKeyDown(KeyCode.Space)) //if you press space load level 1
        {
            SceneManager.LoadScene("Scene_Game");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if you press space load level 1
        {
            SceneManager.LoadScene("Scene_Game");
        }
    }
}
