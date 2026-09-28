using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField] PlatformMovement movement;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) movement.Move();
    }
}
