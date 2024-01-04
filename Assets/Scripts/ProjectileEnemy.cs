using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    float timer = 3;
    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
     rigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer < 1)
        {
            Launch();
            timer = 3;
        }
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2D.position + Vector2.down * 0.5f, projectilePrefab.transform.rotation);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(Vector2.down, 300);
    }

}
