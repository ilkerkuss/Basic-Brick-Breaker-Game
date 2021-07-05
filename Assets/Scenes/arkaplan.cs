using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplan : MonoBehaviour
{
    float akis_hizi = 2.0f;



    // Update is called once per frame
    void Update()
    {
        //z posisyonu -40 dan büyükse zamana bağlı olarak z ekseninde aşağıya doğru hareket et
        if(transform.position.z > -40.0f)
        {
            transform.Translate(0, 0, -akis_hizi * Time.deltaTime);
        }
        else
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 80.0f);
        }
    }
}
