using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameCheck2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Choice.Instance.ShowBox("Sus??", () => {
                Choice.Instance.ShowBox("Sus??", () => {
                    Debug.Log("Sus");
                }, () => {
                    Destroy(gameObject);
                    Debug.Log("Not Sus");
                });
            }, () => {
                SceneManager.LoadScene("Char2-2");
                Debug.Log("Not Sus");
            });
        }
    }
}
