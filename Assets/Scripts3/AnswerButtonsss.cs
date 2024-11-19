using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtonsss : MonoBehaviour
{

    public GameObject answerAbackBlue;
    public GameObject answerAbackGreen;
    public GameObject answerAbackRed;

    public GameObject answerBbackBlue;
    public GameObject answerBbackGreen;
    public GameObject answerBbackRed;

    
    public GameObject answerCbackBlue;
    public GameObject answerCbackGreen;
    public GameObject answerCbackRed;


    public GameObject answerDbackBlue;
    public GameObject answerDbackGreen;
    public GameObject answerDbackRed;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctFX;
    public AudioSource wrongFX;

    public GameObject currentScore;
    public int scoreValue;

    public int bestScore;
    public GameObject bestDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuizzz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }


    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
    }

    public void AnswerA()
    {
        if (QuestionGenerateee.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();

            scoreValue += 5;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongFX.Play();

            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerateee.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();

            scoreValue += 5;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            wrongFX.Play();

            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }
    
    public void AnswerC()
    {
        if (QuestionGenerateee.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();

            scoreValue += 5;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongFX.Play();

            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerateee.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();

            scoreValue += 5;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            wrongFX.Play();

            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {

        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuizzz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        }

        yield return new WaitForSeconds(2);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);


        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerateee.displayingQuestion = false;
    }

}
