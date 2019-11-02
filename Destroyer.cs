using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Destroys C4Rocks
    // Start is called before the first frame update

    [SerializeField]
    GameObject prefabExplosion;

    //timer support
    Timer explodeTimer;

    void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        //check for timer finished and restart
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();
        }

        //Blow up C4 Rock
        GameObject rock = GameObject.FindWithTag("C4Rock");
        if (rock != null)
        {
            Instantiate<GameObject>(prefabExplosion,
                rock.transform.position, Quaternion.identity);
            Destroy(rock);
        }

    }
}
