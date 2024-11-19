using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoJogoNvlFacil;
    [SerializeField] private string nomeDoJogoNvlMedio;
    [SerializeField] private string nomeDoJogoNvlDificil;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelRevisao;
    [SerializeField] private GameObject painelNivelamento;
    [SerializeField] private GameObject painelInstrucoes01;
    [SerializeField] private GameObject painelInstrucoes02;
    [SerializeField] private GameObject painelInstrucoes03;
    [SerializeField] private GameObject painelInstrucoes04;
    [SerializeField] private GameObject painelInstrucoes05;
    [SerializeField] private GameObject painelInstrucoes06;
    [SerializeField] private GameObject painelInstrucoes07;
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private GameObject painelAntesDeJogar01;
    [SerializeField] private GameObject painelAntesDeJogar02;
    [SerializeField] private GameObject painelAntesDeJogar03;
    [SerializeField] private GameObject painelRevisao01;
    [SerializeField] private GameObject painelRevisao02;
    [SerializeField] private GameObject painelRevisao03;
    [SerializeField] private GameObject painelRevisao04;
    [SerializeField] private GameObject painelRevisao05;
    [SerializeField] private GameObject painelRevisao06;
    [SerializeField] private GameObject painelRevisao07;
    [SerializeField] private GameObject painelRevisao08;
    [SerializeField] private GameObject painelRevisao09;
    [SerializeField] private GameObject painelRevisao10;
    [SerializeField] private GameObject painelRevisao11;
    [SerializeField] private GameObject painelRevisao12;
    [SerializeField] private GameObject painelRevisao13;
    [SerializeField] private GameObject painelRevisao14;
    [SerializeField] private GameObject painelRevisao15;
    [SerializeField] private GameObject painelRevisao16;
    [SerializeField] private GameObject painelRevisao17;
    [SerializeField] private GameObject painelRevisao18;
    [SerializeField] private GameObject painelRevisao19;
    [SerializeField] private GameObject painelRevisao20;
    [SerializeField] private GameObject painelRevisao21;
    [SerializeField] private GameObject painelRevisao22;
    [SerializeField] private GameObject painelRevisao23;
    [SerializeField] private GameObject painelRevisao24;
    [SerializeField] private GameObject painelRevisao25;
    [SerializeField] private GameObject painelRevisao26;
    [SerializeField] private GameObject painelRevisao27;
    [SerializeField] private GameObject painelRevisao28;
    [SerializeField] private GameObject painelRevisao29;
    [SerializeField] private GameObject painelRevisao30;
    [SerializeField] private GameObject painelRevisao31;

    public void JogarNvlFacil()
    {
        SceneManager.LoadScene(nomeDoJogoNvlFacil);
    }
    public void JogarNvlMedio()
    {
        SceneManager.LoadScene(nomeDoJogoNvlMedio);
    }
    public void JogarNvlDificil()
    {
        SceneManager.LoadScene(nomeDoJogoNvlDificil);
    }

    public void AbrirNivelamento()
    {
        painelAntesDeJogar03.SetActive(false);
        painelNivelamento.SetActive(true);
    }

    public void FecharNivelamento()
    {
        painelNivelamento.SetActive(false);
        painelAntesDeJogar03.SetActive(true);
    }

    public void AbrirRevisao()
    {
        painelMenuInicial.SetActive(false);
        painelRevisao.SetActive(true);
    }

    public void FecharRevisao()
    {
        painelMenuInicial.SetActive(true);
        painelRevisao.SetActive(false);
    }

    public void AbrirInstrucoes01()
    {
        painelMenuInicial.SetActive(false);
        painelInstrucoes01.SetActive(true);
    }

    public void FecharInstrucoes01()
    {
        painelMenuInicial.SetActive(true);
        painelInstrucoes01.SetActive(false);
    }

    public void AbrirInstrucoes02()
    {
        painelInstrucoes01.SetActive(false);
        painelInstrucoes02.SetActive(true);
    }

    public void FecharInstrucoes02()
    {
        painelInstrucoes01.SetActive(true);
        painelInstrucoes02.SetActive(false);
    }

    public void AbrirInstrucoes03()
    {
        painelInstrucoes02.SetActive(false);
        painelInstrucoes03.SetActive(true);
    }

    public void FecharInstrucoes03()
    {
        painelInstrucoes02.SetActive(true);
        painelInstrucoes03.SetActive(false);
    }

    public void AbrirInstrucoes04()
    {
        painelInstrucoes03.SetActive(false);
        painelInstrucoes04.SetActive(true);
    }

    public void FecharInstrucoes04()
    {
        painelInstrucoes03.SetActive(true);
        painelInstrucoes04.SetActive(false);
    }

    public void AbrirInstrucoes05()
    {
        painelInstrucoes04.SetActive(false);
        painelInstrucoes05.SetActive(true);
    }

    public void FecharInstrucoes05()
    {
        painelInstrucoes04.SetActive(true);
        painelInstrucoes05.SetActive(false);
    }

    public void AbrirInstrucoes06()
    {
        painelInstrucoes05.SetActive(false);
        painelInstrucoes06.SetActive(true);
    }

    public void FecharInstrucoes06()
    {
        painelInstrucoes05.SetActive(true);
        painelInstrucoes06.SetActive(false);
    }

    public void AbrirInstrucoes07()
    {
        painelInstrucoes06.SetActive(false);
        painelInstrucoes07.SetActive(true);
    }

    public void FecharInstrucoes07()
    {
        painelInstrucoes06.SetActive(true);
        painelInstrucoes07.SetActive(false);
    }

    public void AbrirCreditos()
    {
        painelMenuInicial.SetActive(false);
        painelCreditos.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelMenuInicial.SetActive(true);
        painelCreditos.SetActive(false);
    }

    public void AbrirAntesDeJogar01()
    {
        painelMenuInicial.SetActive(false);
        painelAntesDeJogar01.SetActive(true);
    }

    public void FecharAntesDeJogar01()
    {
        painelMenuInicial.SetActive(true);
        painelAntesDeJogar01.SetActive(false);
    }

    public void AbrirAntesDeJogar02()
    {
        painelAntesDeJogar01.SetActive(false);
        painelAntesDeJogar02.SetActive(true);
    }

    public void FecharAntesDeJogar02()
    {
        painelAntesDeJogar01.SetActive(true);
        painelAntesDeJogar02.SetActive(false);
    }

    public void AbrirAntesDeJogar03()
    {
        painelAntesDeJogar02.SetActive(false);
        painelAntesDeJogar03.SetActive(true);
    }

    public void FecharAntesDeJogar03()
    {
        painelAntesDeJogar02.SetActive(true);
        painelAntesDeJogar03.SetActive(false);
    }

    public void AbrirRevisao01()
    {
        painelMenuInicial.SetActive(false);
        painelRevisao01.SetActive(true);
    }
    public void FecharRevisao01()
    {
        painelMenuInicial.SetActive(true);
        painelRevisao01.SetActive(false);
    }
    public void AbrirRevisao02()
    {
        painelRevisao01.SetActive(false);
        painelRevisao02.SetActive(true);
    }
    public void FecharRevisao02()
    {
        painelRevisao01.SetActive(true);
        painelRevisao02.SetActive(false);
    }
    public void AbrirRevisao03()
    {
        painelRevisao02.SetActive(false);
        painelRevisao03.SetActive(true);
    }
    public void FecharRevisao03()
    {
        painelRevisao02.SetActive(true);
        painelRevisao03.SetActive(false);
    }
    public void AbrirRevisao04()
    {
        painelRevisao03.SetActive(false);
        painelRevisao04.SetActive(true);
    }
    public void FecharRevisao04()
    {
        painelRevisao03.SetActive(true);
        painelRevisao04.SetActive(false);
    }
    public void AbrirRevisao05()
    {
        painelRevisao04.SetActive(false);
        painelRevisao05.SetActive(true);
    }
    public void FecharRevisao05()
    {
        painelRevisao04.SetActive(true);
        painelRevisao05.SetActive(false);
    }
    public void AbrirRevisao06()
    {
        painelRevisao05.SetActive(false);
        painelRevisao06.SetActive(true);
    }
    public void FecharRevisao06()
    {
        painelRevisao05.SetActive(true);
        painelRevisao06.SetActive(false);
    }
    public void AbrirRevisao07()
    {
        painelRevisao06.SetActive(false);
        painelRevisao07.SetActive(true);
    }
    public void FecharRevisao07()
    {
        painelRevisao06.SetActive(true);
        painelRevisao07.SetActive(false);
    }
    public void AbrirRevisao08()
    {
        painelRevisao07.SetActive(false);
        painelRevisao08.SetActive(true);
    }
    public void FecharRevisao08()
    {
        painelRevisao07.SetActive(true);
        painelRevisao08.SetActive(false);
    }
    public void AbrirRevisao09()
    {
        painelRevisao08.SetActive(false);
        painelRevisao09.SetActive(true);
    }
    public void FecharRevisao09()
    {
        painelRevisao08.SetActive(true);
        painelRevisao09.SetActive(false);
    }
    public void AbrirRevisao10()
    {
        painelRevisao09.SetActive(false);
        painelRevisao10.SetActive(true);
    }
    public void FecharRevisao10()
    {
        painelRevisao09.SetActive(true);
        painelRevisao10.SetActive(false);
    }
    public void AbrirRevisao11()
    {
        painelRevisao10.SetActive(false);
        painelRevisao11.SetActive(true);
    }
    public void FecharRevisao11()
    {
        painelRevisao10.SetActive(true);
        painelRevisao11.SetActive(false);
    }
    public void AbrirRevisao12()
    {
        painelRevisao11.SetActive(false);
        painelRevisao12.SetActive(true);
    }
    public void FecharRevisao12()
    {
        painelRevisao11.SetActive(true);
        painelRevisao12.SetActive(false);
    }
    public void AbrirRevisao13()
    {
        painelRevisao12.SetActive(false);
        painelRevisao13.SetActive(true);
    }
    public void FecharRevisao13()
    {
        painelRevisao12.SetActive(true);
        painelRevisao13.SetActive(false);
    }
    public void AbrirRevisao14()
    {
        painelRevisao13.SetActive(false);
        painelRevisao14.SetActive(true);
    }
    public void FecharRevisao14()
    {
        painelRevisao13.SetActive(true);
        painelRevisao14.SetActive(false);
    }
    public void AbrirRevisao15()
    {
        painelRevisao14.SetActive(false);
        painelRevisao15.SetActive(true);
    }
    public void FecharRevisao15()
    {
        painelRevisao14.SetActive(true);
        painelRevisao15.SetActive(false);
    }
    public void AbrirRevisao16()
    {
        painelRevisao15.SetActive(false);
        painelRevisao16.SetActive(true);
    }
    public void FecharRevisao16()
    {
        painelRevisao15.SetActive(true);
        painelRevisao16.SetActive(false);
    }
    public void AbrirRevisao17()
    {
        painelRevisao16.SetActive(false);
        painelRevisao17.SetActive(true);
    }
    public void FecharRevisao17()
    {
        painelRevisao16.SetActive(true);
        painelRevisao17.SetActive(false);
    }
    public void AbrirRevisao18()
    {
        painelRevisao17.SetActive(false);
        painelRevisao18.SetActive(true);
    }
    public void FecharRevisao18()
    {
        painelRevisao17.SetActive(true);
        painelRevisao18.SetActive(false);
    }
    public void AbrirRevisao19()
    {
        painelRevisao18.SetActive(false);
        painelRevisao19.SetActive(true);
    }
    public void FecharRevisao19()
    {
        painelRevisao18.SetActive(true);
        painelRevisao19.SetActive(false);
    }
    public void AbrirRevisao20()
    {
        painelRevisao19.SetActive(false);
        painelRevisao20.SetActive(true);
    }
    public void FecharRevisao20()
    {
        painelRevisao19.SetActive(true);
        painelRevisao20.SetActive(false);
    }
    public void AbrirRevisao21()
    {
        painelRevisao20.SetActive(false);
        painelRevisao21.SetActive(true);
    }
    public void FecharRevisao21()
    {
        painelRevisao20.SetActive(true);
        painelRevisao21.SetActive(false);
    }
    public void AbrirRevisao22()
    {
        painelRevisao21.SetActive(false);
        painelRevisao22.SetActive(true);
    }
    public void FecharRevisao22()
    {
        painelRevisao21.SetActive(true);
        painelRevisao22.SetActive(false);
    }
    public void AbrirRevisao23()
    {
        painelRevisao22.SetActive(false);
        painelRevisao23.SetActive(true);
    }
    public void FecharRevisao23()
    {
        painelRevisao22.SetActive(true);
        painelRevisao23.SetActive(false);
    }
    public void AbrirRevisao24()
    {
        painelRevisao23.SetActive(false);
        painelRevisao24.SetActive(true);
    }
    public void FecharRevisao24()
    {
        painelRevisao23.SetActive(true);
        painelRevisao24.SetActive(false);
    }
    public void AbrirRevisao25()
    {
        painelRevisao24.SetActive(false);
        painelRevisao25.SetActive(true);
    }
    public void FecharRevisao25()
    {
        painelRevisao24.SetActive(true);
        painelRevisao25.SetActive(false);
    }
    public void AbrirRevisao26()
    {
        painelRevisao25.SetActive(false);
        painelRevisao26.SetActive(true);
    }
    public void FecharRevisao26()
    {
        painelRevisao25.SetActive(true);
        painelRevisao26.SetActive(false);
    }
    public void AbrirRevisao27()
    {
        painelRevisao26.SetActive(false);
        painelRevisao27.SetActive(true);
    }
    public void FecharRevisao27()
    {
        painelRevisao26.SetActive(true);
        painelRevisao27.SetActive(false);
    }
    public void AbrirRevisao28()
    {
        painelRevisao27.SetActive(false);
        painelRevisao28.SetActive(true);
    }
    public void FecharRevisao28()
    {
        painelRevisao27.SetActive(true);
        painelRevisao28.SetActive(false);
    }
    public void AbrirRevisao29()
    {
        painelRevisao28.SetActive(false);
        painelRevisao29.SetActive(true);
    }
    public void FecharRevisao29()
    {
        painelRevisao28.SetActive(true);
        painelRevisao29.SetActive(false);
    }
    public void AbrirRevisao30()
    {
        painelRevisao29.SetActive(false);
        painelRevisao30.SetActive(true);
    }
    public void FecharRevisao30()
    {
        painelRevisao29.SetActive(true);
        painelRevisao30.SetActive(false);
    }
    public void AbrirRevisao31()
    {
        painelRevisao30.SetActive(false);
        painelRevisao31.SetActive(true);
    }
    public void FecharRevisao31()
    {
        painelRevisao30.SetActive(true);
        painelRevisao31.SetActive(false);
    }


    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();

    }
}
