using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitis_sahne : MonoBehaviour
{
    float akis_hizi = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -40.0f)
        {
            transform.Translate(0,0,-akis_hizi * Time.deltaTime);
        }
        else
        {

            transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z + 40.0f);
        }
    }


}

