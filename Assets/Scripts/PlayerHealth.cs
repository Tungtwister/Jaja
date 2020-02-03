using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int numOfHearts;
    public static int totalHealth;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        totalHealth = 8;
    }
    void Update()
    {
        if (totalHealth > numOfHearts*2) {
            totalHealth = numOfHearts*2;
        }
        if (totalHealth < 0) {
            totalHealth = 0;
        }
        for(int i = 0; i < hearts.Length; i++) {
            if (i == totalHealth/2 && totalHealth % 2 == 1) {
                hearts[i].sprite = halfHeart;
            }
            else if (i < totalHealth/2) {
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts) {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }
        }
        
    }
}
