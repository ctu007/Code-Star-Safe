using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOvere : MonoBehaviour
{
    public GameObject gameOverPanel;
   
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player") == null) // restart dư s
        {
            gameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
