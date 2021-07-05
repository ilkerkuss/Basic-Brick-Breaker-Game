using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyun_kontrolu : MonoBehaviour
{

    public Rigidbody oyuncu_rigi;

    float hiz = 10.0f;
    float yatay_ok_tusu;

    //fizik motoru kullanılacağı için fixedupdate
    private void FixedUpdate()
    {
        oyuncu_hareketi();
    }

    void oyuncu_hareketi()
    {
        yatay_ok_tusu = Input.GetAxis("Horizontal");
        oyuncu_rigi.velocity = (Vector3.right * hiz)*yatay_ok_tusu;
    }

  
}
