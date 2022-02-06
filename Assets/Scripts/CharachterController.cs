using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour
{   
    private Rigidbody rb;
    [SerializeField] private float speed;
    public SpawnMenager spawnMenager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CarMovement();
    }
    private void CarMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal / 2, 0.0f, moveVertical);

        // что бы скорость была стабильной в любом случае
        // и учитывая что мы вызываем из FixedUpdate мы умножаем на fixedDeltaTimе
        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        spawnMenager.SpawnTriggerEnter();
    }
}
