using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private GameObject enemyPrefab;
   [SerializeField] private float[] posX;
   [SerializeField] private float duration, currentTime;

    void Update()
    {
        if (currentTime <= 0)
        {
            currentTime = duration;
            Spawn();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void Spawn()
    {
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = new Vector2(posX[Random.Range(0,posX.Length)],transform.position.y);

        if (newEnemy.transform.position.x == posX[1])
        {
            newEnemy.transform.localScale = new Vector3(newEnemy.transform.localScale.x*-1,0.4f,0f);
        }

    }

}
