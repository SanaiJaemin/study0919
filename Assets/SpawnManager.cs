using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : SingletonBehaviour<SpawnManager>
{
    public GameObject Enemy;
    
    private int ObjectCount = 0;
    private void Awake()
    {
    

        for (int i = 0; i < 5000; i++)
        {
            float radomX = Random.Range(-100, 100);
            float radomZ = Random.Range(-100, 100);

            Enemy.transform.position = new Vector3(radomX, 1, radomZ);
            Instantiate(Enemy, Enemy.transform.position, Quaternion.identity);
          
        }

    }
   


// Update is called once per frame
    void Update()
    {
        
    }

    
}
