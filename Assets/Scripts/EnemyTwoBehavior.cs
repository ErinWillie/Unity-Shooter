using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    void Start()
    {
        // You can initialize any specific properties for EnemyTwo here.
    }

    void Update()
    {
        // Implement the behavior for EnemyTwo.
        // For instance, make it move horizontally.
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 2);

        if (transform.position.x > 19f)
        {
            Destroy(this.gameObject);
        }
    }
}