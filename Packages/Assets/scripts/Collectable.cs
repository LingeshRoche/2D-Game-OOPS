using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Text scoretext;
    public Player player;
    public GameObject playbutton;
    public GameObject Gameover;
    public Text overtext;
    public Text title;
    public GameObject open;
    public GameObject close;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player)
        {
            player.collectable++;
            Destroy(this.gameObject);
            Play();
        }
    }
    public void Play()
    {
        player = FindObjectOfType<Player>();
        Time.timeScale = 1f;
        if (player.enabled)
        {
            scoretext.text = "ITEMS:" + player.collectable.ToString();

        }
        if (player.collectable == 4)
        {
            Time.timeScale = 0f;
            Gameover.SetActive(true);
            open.SetActive(false);
            close.SetActive(true);
            playbutton.SetActive(false);
            overtext.text= "YOU HAVE COLLECTED ALL THE BARRELS.";
            title.text="";

        }
    }
}
