using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Spawn;
    private bool hasSpawned = false;

    public void ButtonClick()
    {
        if (hasSpawned == false)
        {
            SpawnObject(0,0,0);
            hasSpawned = true;
        }
        else
        {
            
        }
    }
    void Start()
    {
        
        
    }

    private void SpawnObject(float posX, float posY, float posZ)
    {
        GameObject newObject;
        newObject = Instantiate(Spawn, new Vector3(0, 0, 0), transform.rotation);
        newObject.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }

}
