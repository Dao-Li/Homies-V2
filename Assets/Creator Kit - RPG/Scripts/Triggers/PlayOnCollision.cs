using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "Player")
    {
        audioSource.Play();
        Debug.Log("Trigger!");
    }

}

void OnTriggerExit2D(Collider2D other)
{
    if (other.gameObject.tag == "Player")
    {
        audioSource.Stop();
        Debug.Log("TriggerExit!");
    }

}

}
