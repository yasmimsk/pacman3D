using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptPlacar : MonoBehaviour
{
    private static GameObject txtPlacar;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("placar", 0);
        txtPlacar = GameObject.Find("txtPlacar");
    }

    public static void incrementarPlacar(int inc)
    {
        int placar = PlayerPrefs.GetInt("placar");
        placar = placar + inc;

        PlayerPrefs.SetInt("placar", placar);
        txtPlacar.GetComponent<Text>().text = "SCORE: " + placar;
    }
}
