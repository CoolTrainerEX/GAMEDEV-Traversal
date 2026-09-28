using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> transforms;
    [SerializeField] private float moveSpeed = 1;
    [SerializeField] private float rotationSpeed = 50;

    private AudioSource audio;

    private int activeTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        activeTransform = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.SetPositionAndRotation(Vector3.MoveTowards(transform.position, transforms[activeTransform].position, moveSpeed * Time.deltaTime), Quaternion.RotateTowards(transform.rotation, transforms[activeTransform].rotation, rotationSpeed * Time.deltaTime));
    }

    public void Move()
    {
        activeTransform = (activeTransform + 1) % transforms.Count;
        audio.Play();
    }
}
