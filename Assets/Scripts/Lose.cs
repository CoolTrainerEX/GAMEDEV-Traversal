using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] Transform spawn;
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip loseSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = other.GetComponent<CharacterController>();

            controller.enabled = false;
            other.transform.position = spawn.position;
            controller.enabled = true;

            audio.PlayOneShot(loseSound);
        }
    }
}
