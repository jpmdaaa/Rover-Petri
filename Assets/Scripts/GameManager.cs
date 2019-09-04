using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
   
    public void RestartLevel()
    {
     
        SceneManager.LoadScene(0);
        
    }
}