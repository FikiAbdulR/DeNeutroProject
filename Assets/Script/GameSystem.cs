using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;

    [SerializeField] private GameObject startingPanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;
    public bool isPaused;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startingPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        pausePanel.SetActive(false);
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

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
        isPaused = true;
    }

    public void PlayGame()
    {
        startingPanel.SetActive(false);
        isPaused = false;
    }
}
