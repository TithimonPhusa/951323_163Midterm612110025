using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsControlScript : MonoBehaviour
{
    
    [SerializeField] Button _backButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToStageSelectClick(Button button){
        SceneManager.UnloadSceneAsync("Credits");
        SceneManager.LoadScene("MainMenu");
    }
}
