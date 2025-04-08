using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Win : MonoBehaviour
{
   public void OnTriggerEnter(Collider collider)
   {
      Debug.Log("se tocan "); //enseÃ±a en la consola
      if (collider.CompareTag("Player"))
      {
         SceneManager.LoadScene("Win", LoadSceneMode.Single);
      }// escena nueva
   }
}
