using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTPcheck : MonoBehaviour
{
    public static string nameObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        nameObj = gameObject.name;
        Destroy(gameObject); 
    }

}
