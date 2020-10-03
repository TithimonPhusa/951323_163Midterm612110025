using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _creditsButton;
    [SerializeField] Button _exitButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(delegate{StartButtonClick(_startButton);});
        _optionsButton.onClick.AddListener (delegate{OptionsButtonClick(_optionsButton);});
        _creditsButton.onClick.AddListener (delegate{CreditsButtonClick(_creditsButton);});
        _exitButton.onClick.AddListener (delegate{ExitButtonClick(_exitButton);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClick(Button button){
        SceneManager.LoadScene("StageSelect");
    }

    public void OptionsButtonClick(Button button){
        if(!GameApplicationManager.Instance.IsOptionMenuActive){
            SceneManager.LoadScene("Options", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive =true;
        }
    }

    public void CreditsButtonClick(Button button){
        if(!GameApplicationManager.Instance.IsOptionMenuActive){
            SceneManager.LoadScene("Credits", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive =true;
        }
    }

    public void ExitButtonClick(Button button){
        Application.Quit();
    }
}
