using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the player === //
    public float speed;

    // === Create a Rigidbody2D variable for the player === //
    Rigidbody2D rigidbody2d;

    // === Create a float variable for the player's Left and Right input === //
    float horizontalInput;

    // === Create a public GameObject variable for the projectile prefab === //

    public GameObject projectilePrefab;
    
    
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // === Write the code below to set your input float variable EQUAL to the player's horizontal inputs (HINT: use ' Input.GetAxis() ') === //
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);

        
        // === Create an if-statement below to get the player's key down and then call the method to launch your projectile/bullet === //
        // ~ HINT: use ' Input.GetKeyDown() ' ~ //

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }

    void Launch()
    {
        // === Add the code below to launch your projectile UP towards the enemy === //
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(Vector2.up, 300);


    }
    
}