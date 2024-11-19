using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public GameObject visual001;
    
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(2, 2);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Se a idade de Ana � a metade da idade de seu irm�o e o seu irm�o tem 14 anos, qual � a idade de Ana?";
                QuestionDisplay.newA = "A. 7";
                QuestionDisplay.newB = "B. 10";
                QuestionDisplay.newC = "C. 14";
                QuestionDisplay.newD = "D. 28";
                actualAnswer = "A";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Se um n�mero x � o triplo do n�mero y e soma deles � 120, quais s�o os n�meros x e y?";
                QuestionDisplay.newA = "A. x = 100 \n y = 20";
                QuestionDisplay.newB = "B. x = 90 \n y = 30";
                QuestionDisplay.newC = "C. x = 80 \n y = 40";
                QuestionDisplay.newD = "D. x = 70 \n y = 50";
                actualAnswer = "B";
            }
            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Se a soma de dois n�meros � 47 e a diferen�a entre eles � 15, quais s�o esses n�meros?";
                QuestionDisplay.newA = "A. x = 31 \n y = 17";
                QuestionDisplay.newB = "B. x = 30 \n y = 17";
                QuestionDisplay.newC = "C. x = 31 \n y = 16";
                QuestionDisplay.newD = "D. x = 29 \n y = 18";
                actualAnswer = "C";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Se a idade de Jo�o � o triplo da idade de sua irm� e a sua irm� tem 10 anos, qual � a idade de Jo�o?";
                QuestionDisplay.newA = "A. 5";
                QuestionDisplay.newB = "B. 20";
                QuestionDisplay.newC = "C. 30";
                QuestionDisplay.newD = "D. 40";
                actualAnswer = "C";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Pedro comprou 3 canecas e 2 cadernos por 60,00 reais. Ana comprou 2 canecas e 1 caderno pagando 35,00 reais. Qual o sistema de equa��es do primeiro grau que melhor representa essa situa��o?";
                QuestionDisplay.newA = "A. {2x + 3y = 60} \n {2x + y = 35}";
                QuestionDisplay.newB = "B. {2x + 3y = 60} \n {x + 2y = 35}";
                QuestionDisplay.newC = "C. {3x + 2y = 60} \n {x + 2y = 35}";
                QuestionDisplay.newD = "D. {3x + 2y = 60} \n {2x + y = 35}";
                actualAnswer = "D";
            }
            if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "No estacionamento de um Shopping existem autom�veis e bicicletas. O n�mero de rodas � 120 e o n�mero de bicicletas � o qu�druplo do n�mero de autom�veis. Qual � o sistema de equa��es do primeiro grau que melhor representa essa situa��o?";
                QuestionDisplay.newA = "A. {4c + 2b = 120} \n {b = 4c}";
                QuestionDisplay.newB = "B. {4c + 2b = 120} \n {4b = c}";
                QuestionDisplay.newC = "C. {4b + 2c = 120} \n {b = 4c}";
                QuestionDisplay.newD = "D. {4b + 2c = 120} \n {4b = c}";
                actualAnswer = "A";
            }
            if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "A soma das idades de Pedro e Paulo � 44 anos e a diferen�a � de 16 anos. Qual o sistema de equa��es do primeiro grau que melhor representa essa situa��o?";
                QuestionDisplay.newA = "A. {x + y = 44} \n {x - y = 16}";
                QuestionDisplay.newB = "B. {x + y = 44} \n {x + y = 16}";
                QuestionDisplay.newC = "C. {x - y = 44} \n {x + y = 16}";
                QuestionDisplay.newD = "D. {x - y = 44} \n {x - y = 16}";
                actualAnswer = "A";
            }
            if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Em um restaurante, um cliente pediu 3 hamb�rgueres e 2 refrigerantes por um total de 15 reais. Outro cliente pediu 2 hamb�rgueres e 1 refrigerante por um total de 8 reais. Qual � o sistema de equa��es que representa os pedidos desses dois clientes?";
                QuestionDisplay.newA = "A. {x + y = 15} \n {2x + 3y = 8}";
                QuestionDisplay.newB = "B. {2x + 3y = 15 } \n {x + 2y = 8}";
                QuestionDisplay.newC = "C. {3x + 2y = 15} \n {2x + y = 8}";
                QuestionDisplay.newD = "D. {3x + y = 15} \n {2x + 2y = 8}";
                actualAnswer = "C";
            }
            QuestionDisplay.pleaseUpdate = false;
        }

    }
}
