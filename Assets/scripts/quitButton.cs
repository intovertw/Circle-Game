using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitButton : MonoBehaviour
{
    public Button quitBtn;

    private void Start()
    {
        quitBtn.onClick.AddListener(quitGame);
    }

    void quitGame()
    {
        Application.Quit();
    }
}
