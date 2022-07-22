using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private GameObject player;
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private float HP = 10f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 direction = player.transform.position- transform.position ;
        direction = direction.normalized;
        transform.position += direction * Time.deltaTime * speed;

        if (HP < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            HP--;
            Destroy(collision.gameObject);
        }
        
    }
}
