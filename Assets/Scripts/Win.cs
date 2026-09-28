using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip winSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) audio.PlayOneShot(winSound);
    }
}
