using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
                Debug.Log("Not Sus");
            });
        }
    }
}
