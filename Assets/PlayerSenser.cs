using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSenser : MonoBehaviour
{
   public Transform EnemyPosition;
   public List<GameObject> Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = new List<GameObject>();


    }

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector3.Distance(transform.position, EnemyPosition.position);
        if(Distance < 5f)
        {
            Enemy.Add(gameObject);
        }
        Debug.Log($"{Enemy.Count}");
       

    }
}
