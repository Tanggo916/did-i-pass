using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public static Choice Instance { get; private set; }

    private TextMeshProUGUI textMeshPro;
    private Button yesBtn;
    private Button noBtn;

    private void Awake()
    {
        Instance = this;
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        yesBtn = transform.Find("yesBtn").GetComponent<Button>();
        noBtn = transform.Find("noBtn").GetComponent<Button>();

        Hide();
    }

    public void ShowBox(string questionText, Action yesAction, Action noAction)
    {
        textMeshPro.text = questionText;    
        yesBtn.onClick.AddListener(() =>
        {
            Hide();
            yesAction();
        });
        noBtn.onClick.AddListener(() =>
        {
            Hide();
            noAction();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

}
