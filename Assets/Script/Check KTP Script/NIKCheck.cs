using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NIKCheck : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Choice.Instance.ShowBox("Apakah benar??", () => {
                Choice.Instance.ShowBox("Apakah benar??", () => {
                    Destroy(gameObject);
                    Debug.Log("Sus");
                },() => {
                    /*SceneManager.LoadScene("Char1-2");*/
                    Debug.Log("Not Sus");
                });
            }, () => {
                
                Debug.Log("Not Sus");
            });
        }
    }
}
