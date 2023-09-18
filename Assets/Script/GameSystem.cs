using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Point"))
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Restart()
    {
        Application.LoadLevel("Gameplay");
        Time.timeScale = 1;
    }
}
