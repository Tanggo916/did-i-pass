using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BulatScript : MonoBehaviour, IClicked
{
    [SerializeField] private string NewScene;
    public void OnClickAction()
    {
        SceneManager.LoadScene(NewScene);
    }
}
