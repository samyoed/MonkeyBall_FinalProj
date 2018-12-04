using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCameraTiltUp : MonoBehaviour
{

    int spin = 360;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        spin += -1;
        if (spin >= 0)
        {
            transform.Rotate(-0.25f * Time.deltaTime * 60f, 0f, 0f);
        }
    }
}




































//Trynna find a way to find some meaning
//Why do I listen to everyone?  It only makes me hate myself
//They tell me I know what'll make me happy
//They treat my like an expiriment
//They treat me like a doll

//I've done my best
//And I'll keep on going
//But people like us
//Are always destined to fall