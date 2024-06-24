using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onplaybutton(){
        Scorescript.scorevalue = 0;
        SceneManager.LoadScene(1);
    }
}
