using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float _speed = 2f;
     public bool ChangeMov = false;
    GameObject[] enemy2List = null;
    float i;
    public float movementDifference;
    float bossZ;
    float bossX;
    float EnemyX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy2List = GameObject.FindGameObjectsWithTag("Enemy");


        
        
            MovementCheck();

        
       

        
        

        
    }
    void MovementCheck()
    {
        bossZ= GetComponent<Transform>().position.z;
        bossX= GetComponent<Transform>().position.x;
        movementDifference = 2;
        //transform.Translate(Vector3.back* _speed* Time.deltaTime);
        
        //goes through the enemy list
        for(int i = 0; i < enemy2List.Length; i++)
        {
            
            //if an enemys x coordinate is the same as the bosses x coordinate we enter loop
            if (enemy2List[i].transform.position.x ==bossX )
            {
                //Debug.Log(" an enemy has the same x as the boss");
                //Debug.Log("boss info");
                //Debug.Log("boss z is"+bossZ);
               
                //Debug.Log("Enemy z is"+enemy2List[i].transform.position.z);
                
                //if the enemys z position is within 3 int of the boses z positonj we enter if
                if (bossZ -enemy2List[i].transform.position.z <movementDifference )
                {
                    Debug.Log("checking if the boss is about to collide");
                    //we tell the boss to change movment as it is about to collide
                    MovementChange();
                    ChangeMov = true;
                }
                
                
                
            }


        }
        // if the boss did not need to change move we can have the boss move normally
        if(ChangeMov==false)
        {
            NormalMovement();
        }


        
    }
    void NormalMovement()
    {
        transform.position += new Vector3(0, 0, -1) * _speed * Time.deltaTime;

    }
    void MovementChange()
    {
        // in this the boss well move the same as the other objects
        transform.position += new Vector3(0, 0, -6) * Time.deltaTime;
        //the changemove has happened and now it returns to false
        ChangeMov=false;

    }
}
