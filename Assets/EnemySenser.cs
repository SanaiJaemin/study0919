using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySenser : MonoBehaviour
{
    public Transform Player;
    private MeshRenderer _meshRenderer;
    
    bool[] EnterEnemy = new bool[30];
    List<float> EnemyDistance = new List<float>();
    // Start is called before the first frame update
    void Awake()
    {

        _meshRenderer = GetComponent<MeshRenderer>();
    }

   
    void FixedUpdate()
    {

        float Distance = Vector3.Distance(transform.position, Player.transform.position);
        if (Distance < 5f)
        {    
           
            EnemyDistance.Add(Distance);
            for(int i = 0; i <  EnemyDistance.Count;i++)
            {
                float min = EnemyDistance[0];
                if(EnemyDistance[i] < min)
                {
                    min = EnemyDistance[i];
                }
                if(Distance == min)
                {
                    _meshRenderer.material.color = Color.red;
                }
                
            }


        }
        else
        {
            _meshRenderer.material.color = Color.green;
        }
    }
}
