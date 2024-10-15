using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    Vector3 ScrollSpeed = new Vector3(0.0f, 0.01f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ScrollSpeed;
        if (transform.position.y >= 24.0f)
        {
            Destroy(gameObject);
        }
    }


}
