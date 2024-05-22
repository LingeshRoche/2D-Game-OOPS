using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public Text scoretext;
    public Player player;
    public GameObject playbutton;
    public GameObject Gameover;
    public GameObject open;
    public GameObject close;
    public void Start()
    {
        scoretext.text = "ITEMS";
        player.enabled = false;
        playbutton.SetActive(true);
        Gameover.SetActive(false);
        Time.timeScale = 0f;
        open.SetActive(false);
        close.SetActive(true);

    }
    public void PlayButton()
    {
        player.enabled = true;
        playbutton.SetActive(false);
        Gameover.SetActive(false);
        Time.timeScale = 1f;
        scoretext.text = "ITEMS";
        open.SetActive(true);
        close.SetActive(false);

    }
   






}

