using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectControlScript : MonoBehaviour
{

    [SerializeField] Button _backButton;
    [SerializeField] Button _stage1Button;
    [SerializeField] Button _stage2Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMainMenuButtonClick(Button button){
        SceneManager.UnloadSceneAsync("StageSelect");
        SceneManager.LoadScene("MainMenu");
    }
    public void ToStage1ButtonClick(Button button){
        SceneManager.UnloadSceneAsync("StageSelect");
        SceneManager.LoadScene("Stage1");
    }
    public void ToStage2ButtonClick(Button button){
        SceneManager.UnloadSceneAsync("StageSelect");
        SceneManager.LoadScene("Stage2");
    }
}
