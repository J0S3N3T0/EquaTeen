using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltarrr : MonoBehaviour
{
    [SerializeField] private string voltarAoMenu;

    public void BackAoMenu()
    {
        SceneManager.LoadScene(voltarAoMenu);
    }

}
