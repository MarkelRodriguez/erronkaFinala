using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Npgsql;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public TextMeshProUGUI userTxt;
    public TMP_InputField userInput;
    private string erabiltzailea;
    // Start is called before the first frame update
    void Start()
    {
        userTxt.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        if (userInput.text.Length != 0)
        {
            erabiltzailea = userInput.text;
            PlayerPrefs.SetString("Erabiltzailea", erabiltzailea);
            Debug.Log(erabiltzailea);
            SceneManager.LoadScene("Jokua");
        }
        else
        {
            userTxt.gameObject.SetActive(true);
            Debug.Log("The user You enter is wrong, try again");
        }

    }

    public void Close()
    {
        Application.Quit();
    }
}
