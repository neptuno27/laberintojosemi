using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //carga la escena principal de juego
    }
    public void GameQuit(){
        Application.Quit(); //cerrar juego
        Debug.Log("Se apagó");
    }
}
