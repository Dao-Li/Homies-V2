using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCornVideo : MonoBehaviour
{
    public GameObject videoPlayer;

    void Start() {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter2D (Collider2D other) {
    if (other.gameObject.tag == "playerVideo")
    {
        videoPlayer.SetActive(true);
        Debug.Log("VideoTrigger!");
    }

    }

    void OnTriggerExit2D(Collider2D other)
    {
    if (other.gameObject.tag == "playerVideo")
    {
       videoPlayer.SetActive(false);
        Debug.Log("VideoTriggerExit!");
    }

    }
    
}

