using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebrisCounter : MonoBehaviour
{
    public int inhand;
    public int thrown;
    public Text counter;

    public Text highText;

    public void AddScore()
    {
        inhand++;
    }

    private void Update() {
        int high = PlayerPrefs.GetInt("highscore");
        if (thrown > high)
        {
            PlayerPrefs.SetInt("highscore",thrown);
        }
        counter.text = "Toplanan:\n" + inhand.ToString() + "\n\nYok Edilen:\n" + thrown.ToString();
        highText.text = "Yok Etme Rekoru:\n" + high.ToString() + "\n\nZorluk\n" + PlayerPrefs.GetString("difficulty");
    }
}