using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : SingletonBehaviour<SpawnManager>
{
    
    public GameObject Prefebs;
    

    private void Awake()
    {
        for (int i = 0; i < 100; i++)
        {
           
            float radomX = Random.Range(-100, 100);
            float radomZ = Random.Range(-100, 100);

            Prefebs.transform.position = new Vector3(radomX, 1, radomZ);
            Instantiate(Prefebs, Prefebs.transform.position, Quaternion.identity);
          
        }

  
        
    }
   


// Update is called once per frame
    void Update()
    {
        
    }

    
}
