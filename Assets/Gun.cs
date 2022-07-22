using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    private Vector2 position;
    [SerializeField]
    private float BulletSpeed = 5f;
    [SerializeField]
    private float FireRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            position = transform.position;
            Vector2 mousePos = Input.mousePosition;
            mousePos.x = (mousePos.x - 1920 / 2) * 17.8f/1920f*2;
            mousePos.y = (mousePos.y - 1080 / 2) * 9.95f/1080f*2; 
            GameObject bullet = Instantiate(BulletPrefab, position, transform.rotation);
            Vector2 direction = mousePos-position;
            direction = direction.normalized;
            Debug.Log("MousePos" + mousePos);
            Debug.Log("Pos" + position);
            Debug.Log(direction);
            direction = direction.normalized;
            bullet.gameObject.GetComponent<Rigidbody2D>().AddForce(direction*BulletSpeed, ForceMode2D.Impulse);
            Destroy(bullet, 5);
        }
        

    }
  
}
