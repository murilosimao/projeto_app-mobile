using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{
    [SerializeField] private string nameScene;
    public void HandleBtnNext()
    {
        SceneManager.LoadScene(nameScene);
    }
}
