using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioButton2 : MonoBehaviour
{
    public AudioSource audioSource;
    private bool hasSpawned = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        if (hasSpawned == false)
        {
            audioSource.Play();
            hasSpawned = true;
        }
        else
        {
            SceneManager.LoadScene("HasilFoto 2");
        }

    }
}
