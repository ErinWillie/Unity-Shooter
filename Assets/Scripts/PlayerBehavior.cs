using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;
    public float horizontalScreenLimit;

    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        horizontalScreenLimit = 19f;
    }

    // Update is called once per frame; if your computer runs at 60 fps
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed;

        // Keep the player within the specified vertical limits
        newPosition.y = Mathf.Clamp(newPosition.y, -6.5f, 0);

        // Wrap around the screen horizontally
        if (newPosition.x > horizontalScreenLimit)
        {
            newPosition.x = -horizontalScreenLimit;
        }
        else if (newPosition.x < -horizontalScreenLimit)
        {
            newPosition.x = horizontalScreenLimit;
        }

        transform.position = newPosition;
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}