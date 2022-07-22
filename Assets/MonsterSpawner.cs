using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject MonsterPrefab;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SpawnMonster", 1, 0.5f);
    }
    void SpawnMonster()
    {
        float x = player.transform.position.x + Random.Range(-20, 20);
        float y = player.transform.position.y + Random.Range(-20, 20);
        float distance = Vector2.Distance(new Vector2(x, y), player.transform.position);
        while (true)
        {
            if (distance < 10)
            {
                x = player.transform.position.x + Random.Range(-20, 20);
                y = player.transform.position.y + Random.Range(-20, 20);
                distance = Vector2.Distance(new Vector2(x, y), player.transform.position);
            }
            else break;
            if(Time.deltaTime > 10)
            {
                break;
            }
        }
        Vector2 SpawnPosition = new Vector2(x, y);
        Instantiate(MonsterPrefab, SpawnPosition, transform.rotation);
    }
}
