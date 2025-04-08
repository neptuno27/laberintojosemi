using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spritecontroller : MonoBehaviour
{
    public GameObject Pausa;
    public Sprite pauseSprite;
    public Sprite playSprite;
    // Start is called before the first frame update
    void Start()
    {
        Pausa= gameObject;
        //accion
        Sprite Load(string imageName, string spriteName)
        {
            Sprite[] all = Resources.LoadAll<Sprite>(imageName);
            foreach(var s in all)
            {
                if (s.name == spriteName)
                {
                    return s;
                }
            }
            return null;
        }
        // a quien se le hace la accion

        playSprite = Load("play-pause","Play"); //sprite de play
        pauseSprite = Load("play-pause","Pausa"); //sprite de pausa


        //nombre variable = carga (la imagen x, la parte x);
        }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Pausa.GetComponent<Image>().sprite = playSprite;
        }
        else
        {
            Pausa.GetComponent<Image>().sprite = pauseSprite;
        }
    }
}
