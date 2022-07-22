using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D Rigid;
    // Start is called before the first frame update
    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
