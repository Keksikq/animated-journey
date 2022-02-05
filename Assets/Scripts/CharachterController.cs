using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour
{
    public float speed;
    public SpawnMenager spawnMenager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * speed / 2;
        float vMovement = Input.GetAxis("Vertical") * speed;
        transform.Translate(new Vector3( hMovement , 0 , vMovement)  * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        spawnMenager.SpawnTriggerEnter();
    }
}
