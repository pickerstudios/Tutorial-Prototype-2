using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    private float TopBound = 30f;
    private float LowBound = -10f;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
