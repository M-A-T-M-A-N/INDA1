using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    private AudioSource source;
    [SerializeField]
    private AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Skull")
        {
            Debug.Log("Ouch! Try not to collect the Skulls");
        }
        else if (gameObject.name == "Shield")
        {
            Debug.Log("Woohoo! More Health");
        }
        else if (gameObject.name == "Gold Ingots")
        {
            Debug.Log("Yay! Gold");
        }
        source = other.GetComponent<AudioSource>();
        source.PlayOneShot(collectSound, 1f);
        Destroy(gameObject);
    }
}
