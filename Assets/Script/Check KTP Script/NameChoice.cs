using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChoice : MonoBehaviour
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
                
                Debug.Log("Not Sus");
            });
        }
    }
}
