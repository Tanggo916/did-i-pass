using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public QuestionAndAnswer[] questionAndAnswers;
    private static List<QuestionAndAnswer> unansweredQuestions;

    private QuestionAndAnswer currentQuestion;

    [SerializeField]
    private TextMeshProUGUI textComponent;

    [SerializeField]
    private TextMeshProUGUI trueAnswerText;

    [SerializeField]
    private TextMeshProUGUI falseAnswerText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questionAndAnswers.ToList<QuestionAndAnswer>();
        }

        SetCurrentQuestion();
        
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        textComponent.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "KAMU BENAR";
            falseAnswerText.text = "KAMU SALAH";
        }
        else
        {
            trueAnswerText.text = "KAMU SALAH";
            falseAnswerText.text = "KAMU BENAR";
        }

        
    }

    IEnumerator TransitionToNextQuestions()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (unansweredQuestions.Count == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
       
    }

    public void UserBenar()
    {
        animator.SetTrigger("Benar");
        if (currentQuestion.isTrue)
        {
            Debug.Log("Benar");
        }
        else
        {
            
            Debug.Log("Salah");
        }

        StartCoroutine(TransitionToNextQuestions());
    }

    public void UserSalah()
    {
        animator.SetTrigger("Salah");
        if (!currentQuestion.isTrue)
        {
            
            Debug.Log("Benar");
        }
        else
        {
            Debug.Log("Salah");
        }

        StartCoroutine(TransitionToNextQuestions());
    }

}