using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
   
   [SerializeField] private float moveSpeed;
    void Update()
    {
        transform.Translate(0f,moveSpeed*Time.deltaTime,0f);

        if (transform.position.y >= 5.5)
        {
            Destroy(gameObject);
        }
    }
}
