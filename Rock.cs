using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update

    // death support
    const float RockLifespanSeconds = 10;
    Timer deathTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get teddy bear moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = RockLifespanSeconds;
        deathTimer.Run();
    }

    //fire when the rock has left the scene
    void OnBecameInvisible()

    {

        //destroy the rock

        Destroy(gameObject);

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }
}
