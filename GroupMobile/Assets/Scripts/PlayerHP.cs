using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

    public int hp = 10;
    public Text hpText;
    public Slider hpBar;

    void Start()
    {
        hpText.GetComponent<Text>().text = "HP: " + hp;
        hpBar.GetComponent<Slider>().value = hp;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hp--;
            hpText.GetComponent<Text>().text = "HP: " + hp;
            hpBar.GetComponent<Slider>().value = hp;

            if (hp <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
