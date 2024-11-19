using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerateee : MonoBehaviour
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

                QuestionDisplayyy.newQuestion = "Em um estacionamento, com vagas para motos e carros, Ant�nio observou que havia 40 ve�culos. Ele tamb�m observou que havia um total de 108 rodas. Qual a quantidade de motos e carros no estacionamento?";
                QuestionDisplayyy.newA = "A. Motos = 27 \n Carros = 13";
                QuestionDisplayyy.newB = "B. Motos = 24 \n Carros = 16";
                QuestionDisplayyy.newC = "C. Motos = 25 \n Carros = 15";
                QuestionDisplayyy.newD = "D. Motos = 26 \n Carros = 14";

                actualAnswer = "D";
            }

            if (questionNumber == 2)
            {

                QuestionDisplayyy.newQuestion = "J�lia foi a uma livraria para comprar uma r�gua e um estojo. A soma dos pre�os de 2 r�guas e 1 estojo � 60 reais. O pre�o do estojo � 30 reais mais caro que o pre�o de 4 r�guas. Quanto J�lia ir� gastar para comprar 1 r�gua e 1 estojo?";
                QuestionDisplayyy.newA = "A. R$ 50,00";
                QuestionDisplayyy.newB = "B. R$ 55,00";
                QuestionDisplayyy.newC = "C. R$ 60,00";
                QuestionDisplayyy.newD = "D. R$ 65,00";

                actualAnswer = "B";
            }

            if (questionNumber == 3)
            {

                QuestionDisplayyy.newQuestion = "No s�tio de Amanda tem galinhas e cabritos num total de 45 cabe�as e 120 p�s. Assim, quantas galinhas e quantos cabritos h� no s�tio de Amanda?";
                QuestionDisplayyy.newA = "A. galinhas = 30 \n cabritos = 15";
                QuestionDisplayyy.newB = "B. galinhas = 25 \n cabritos = 20";
                QuestionDisplayyy.newC = "C. galinhas = 23 \n cabritos = 22";
                QuestionDisplayyy.newD = "D. galinhas = 35 \n cabritos = 10";

                actualAnswer = "A";
            }

            if (questionNumber == 4)
            {

                QuestionDisplayyy.newQuestion = "O par ordenado (x,y) � a solu��o do sistema: \n {x + y = 30} \n {x - y = 4} \n Dessa forma, qual o valor de x2 - y2?";
                QuestionDisplayyy.newA = "A. 120";
                QuestionDisplayyy.newB = "B. 100";
                QuestionDisplayyy.newC = "C. 130";
                QuestionDisplayyy.newD = "D. 110";

                actualAnswer = "A";
            }

            if (questionNumber == 5)
            {

                QuestionDisplayyy.newQuestion = "Maria comprou 3 coxinhas e um refrigerante pagando 24 reais. O seu irm�o Lucas, comprou 1 coxinha e 1 refrigerante e pagou 10 reais. Quanto Felipe vai pagar, caso ele queira comprar 2 coxinhas e 2 refrigerantes?";
                QuestionDisplayyy.newA = "A. R$ 15,00";
                QuestionDisplayyy.newB = "B. R$ 20,00";
                QuestionDisplayyy.newC = "C. R$ 23,00";
                QuestionDisplayyy.newD = "D. R$ 25,00";

                actualAnswer = "B";
            }

            if (questionNumber == 6)
            {

                QuestionDisplayyy.newQuestion = "Clara e Pedro sa�ram para lanchar e a conta deles foi de 57 reais. A conta de Pedro foi o dobro do valor de Clara. Quanto Pedro pagou a mais?";
                QuestionDisplayyy.newA = "A. R$ 19,00";
                QuestionDisplayyy.newB = "B. R$ 20,00";
                QuestionDisplayyy.newC = "C. R$ 21,00";
                QuestionDisplayyy.newD = "D. R$ 22,00";

                actualAnswer = "A";
            }

            if (questionNumber == 7)
            {

                QuestionDisplayyy.newQuestion = "Andr� gosta de gato e cachorro. Um colega perguntou-lhe quantos ele tem. Andr� respondeu da seguinte maneira: �A soma do triplo do n�mero de cachorros com o dobro do n�mero de gatos � igual a 19 e a diferen�a entre o n�mero de cachorros e de gatos � 3�. Qual � a alternativa que corresponde � quantidade de cachorros e gatos?";
                QuestionDisplayyy.newA = "A. 5 cachorros \n 2 gatos";
                QuestionDisplayyy.newB = "B. 6 cachorros \n 3 gatos";
                QuestionDisplayyy.newC = "C. 4 cachorros \n 3 gatos";
                QuestionDisplayyy.newD = "D. 5 cachorros \n 3 gatos";

                actualAnswer = "A";
            }

            if (questionNumber == 8)
            {

                QuestionDisplayyy.newQuestion = "Qual o valor de x + y no seguinte sistema de equa��es do primeiro grau: \n {2x + 6y = 20} \n {4x + 2y = 10}";
                QuestionDisplayyy.newA = "A. 3";
                QuestionDisplayyy.newB = "B. 4";
                QuestionDisplayyy.newC = "C. 5";
                QuestionDisplayyy.newD = "D. 6";

                actualAnswer = "B";
            }

            //

            QuestionDisplayyy.pleaseUpdate = false;

        }
    }
}
