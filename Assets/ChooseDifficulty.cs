using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseDifficulty : MonoBehaviour
{
    public void ChooseDif(string dif)
    {
        PlayerPrefs.SetString("difficulty",dif);
    }
}
