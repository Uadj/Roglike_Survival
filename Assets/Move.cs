using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField]
    private float speed = 2.5f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(x, y);
        Vector3 dir2 = dir;
        transform.position += dir2*Time.deltaTime*speed;

    }
}
