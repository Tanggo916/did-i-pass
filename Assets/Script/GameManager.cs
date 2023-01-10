using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Spawn;
    public int digit;
    private bool hasSpawned = false;

    public void ButtonClick()
    {
        if (hasSpawned == false)
        {
            digit = Random.Range(0, 10);
            if (digit >=5)
            {
            SpawnObject(0,0,0);
            hasSpawned = true;

            }
            else
            {
                MoveToScene(0);
            }
        }
    }
    void Start()
    {
        
    }

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    private void SpawnObject(float posX, float posY, float posZ)
    {
        GameObject newObject;
        newObject = Instantiate(Spawn, new Vector3(0, 0, 0), transform.rotation);
        newObject.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }

}
