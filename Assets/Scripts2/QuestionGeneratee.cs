using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGeneratee : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(7, 7);

            if (questionNumber == 1)
            {
                QuestionDisplayy.newQuestion = "A soma das idades de Ana e M�rcio � 80 anos. Sabendo que a idade de Ana � o triplo da idade de M�rcio, qual � a idade de cada um deles?";
                QuestionDisplayy.newA = "A. Ana = 60 \n M�rcio = 20";
                QuestionDisplayy.newB = "B. Ana = 50 \n M�rcio = 30";
                QuestionDisplayy.newC = "C. Ana = 40 \n M�rcio = 40";
                QuestionDisplayy.newD = "D. Ana = 65 \n M�rcio = 15";
                actualAnswer = "A";
            }

            if (questionNumber == 2)
            {
                QuestionDisplayy.newQuestion = "Qual � o valor das vari�veis x e y no sistema: \n {x + 2y = 7} \n {3x - y = 7}";
                QuestionDisplayy.newA = "A. {x = 3} \n {y = 3}";
                QuestionDisplayy.newB = "B. {x = 3} \n {y = 2}";
                QuestionDisplayy.newC = "C. {x = 2} \n {y = 3}";
                QuestionDisplayy.newD = "D. {x = 2} \n {y = 2}";
                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {
                QuestionDisplayy.newQuestion = "No estacionamento de uma escola, temos x carros e y motos. S�o 22 ve�culos e 80 pneus. Quantos carros e quantas motos h� no estacionamento da escola?";
                QuestionDisplayy.newA = "A. Carros = 16 \n Motos = 6";
                QuestionDisplayy.newB = "B. Carros = 15 \n Motos = 7";
                QuestionDisplayy.newC = "C. Carros = 18 \n Motos = 4";
                QuestionDisplayy.newD = "D. Carros = 20 \n Motos = 2";
                actualAnswer = "C";
            }

            if (questionNumber == 4)
            {
                QuestionDisplayy.newQuestion = "Qual o valor de x e y no seguinte sistema de equa��es do primeiro grau: \n {x = y + 8} \n {x + y = 40}";
                QuestionDisplayy.newA = "A. {x = 24} \n {y = 16}";
                QuestionDisplayy.newB = "B. {x = 25} \n {y = 15}";
                QuestionDisplayy.newC = "C. {x = 23} \n {y = 17}";
                QuestionDisplayy.newD = "D. {x = 20} \n {y = 10}";
                actualAnswer = "A";
            }

            if (questionNumber == 5)
            {
                QuestionDisplayy.newQuestion = "Em um feriado, Milene resolveu 40 quest�es de matem�tica a mais que Luana. Juntas, elas resolveram um total de 150 quest�es. Qual o n�mero total de quest�es que Milene resolveu?";
                QuestionDisplayy.newA = "A. 90";
                QuestionDisplayy.newB = "B. 95";
                QuestionDisplayy.newC = "C. 100";
                QuestionDisplayy.newD = "D. 105";
                actualAnswer = "B";
            }

            if (questionNumber == 6)
            {
                QuestionDisplayy.newQuestion = "Qual o valor de x.y no sistema de equa��es do primeiro grau: \n {4x + y = 5} \n {4x + 3y = 23}";
                QuestionDisplayy.newA = "A. 9";
                QuestionDisplayy.newB = "B. -9";
                QuestionDisplayy.newC = "C. 7";
                QuestionDisplayy.newD = "D. -7";
                actualAnswer = "B";
            }

            if (questionNumber == 7)
            {
                QuestionDisplayy.newQuestion = "Thiago fez um teste de matem�tica. Ele ganhou 4 pontos em cada quest�o que acertou e perdeu 2 pontos em cada quest�o que errou. Ao final de 25 quest�es ele conseguiu um total de 70 pontos. Quantas quest�es ele acertou?";
                QuestionDisplayy.newA = "A. 15";
                QuestionDisplayy.newB = "B. 17";
                QuestionDisplayy.newC = "C. 20";
                QuestionDisplayy.newD = "D. 22";
                actualAnswer = "C";
            }

            if (questionNumber == 8)
            {
                QuestionDisplayy.newQuestion = "Dado um sistema de equa��es de primeiro grau: \n {x = 2y} \n {x + y = 120} \n Qual ser� o valor de x-y ?";
                QuestionDisplayy.newA = "A. 20";
                QuestionDisplayy.newB = "B. 30";
                QuestionDisplayy.newC = "C. 40";
                QuestionDisplayy.newD = "D. 50";
                actualAnswer = "C";
            }

            //
            QuestionDisplayy.pleaseUpdate = false;
        }
    }
}
