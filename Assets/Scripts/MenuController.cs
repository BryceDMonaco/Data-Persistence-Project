using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public TMPro.TMP_InputField nameInputField;
    public Button startButton;

    public string userName;
    // Start is called before the first frame update
    void Start()
    {
        startButton.enabled = false;
    }

    // Update is called once per frame
    void Awake()
    {
        if (FindObjectsOfType<MenuController>().Length > 1)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public void NameChanged(string inputName)
    {
        if (inputName == string.Empty || inputName == "" || inputName == null)
        {
            startButton.enabled = false;
            userName = "";
        }
        else
        {
            startButton.enabled = true;
            userName = inputName;
        }
    }

    public void LoadGameLevel()
    {
        SceneManager.LoadScene("main");
    }
}
