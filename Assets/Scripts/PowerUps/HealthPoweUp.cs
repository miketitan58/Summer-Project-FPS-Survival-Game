using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoweUp : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private float rotationSpeed;
    private float randomRotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // set a variable with a random rotation
        float randomRotationSpeed = Random.Range(-10, 10);
        // set the rotation of the object 
        transform.rotation = Random.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        transform.Rotate(transform.rotation * new Vector3(rotationSpeed, 0, randomRotationSpeed));
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
