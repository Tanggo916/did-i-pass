using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PicChoice : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Choice.Instance.ShowBox("Sus??", () => {
                Choice.Instance.ShowBox("Sus??", () => {
                    Debug.Log("Sus");
                },() => {
                    Debug.Log("Not Sus");
                });
            }, () => {
                Destroy(gameObject);
                SceneManager.LoadScene("Char1-2");
                Debug.Log("Not Sus");
            });
        }
    }
}
