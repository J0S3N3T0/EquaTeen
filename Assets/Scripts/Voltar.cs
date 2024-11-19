using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltar : MonoBehaviour
{
    [SerializeField] private string voltarAoMenu;

    public void BackAoMenu()
    {
        SceneManager.LoadScene(voltarAoMenu);
    }

}
