using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HudController : MonoBehaviour
{

    public GameObject[] Life;


    
    public void infoBtn(){
        SceneManager.LoadScene("Info_01");
    }   

    public void confirmButton(){
        SceneManager.LoadScene("Quest_01");
    }

    public void configButton(){
        SceneManager.LoadScene("Config");
    }

    public void infor01 (){
        SceneManager.LoadScene("Info_01");
    }

    public void StartGame (){
        SceneManager.LoadScene("Game");
    }

    public void Sobre (){
        SceneManager.LoadScene("Sobre");
    }

    public void QuitGame (){
        Application.Quit();
    }

    public void BackMainMeun(){
        SceneManager.LoadScene("MainMenu");
    }

    public void BackGame(){
        SceneManager.LoadScene("Game");
    }

    public void fimRuimGame(){
        SceneManager.LoadScene("Game");
    }

    public void fimBomGame(){
        SceneManager.LoadScene("Game");
    }

}
