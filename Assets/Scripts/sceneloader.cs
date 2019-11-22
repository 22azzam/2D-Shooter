using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public bool spaceBar = false;
    public string scene;
    public void loadscene()
    {
        SceneManager.LoadScene(scene);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spaceBar)
        {
            SceneManager.LoadScene(scene);
        }
    }
}