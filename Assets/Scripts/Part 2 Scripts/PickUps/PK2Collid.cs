using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PK2Collid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            PickUpManager.pk2 = true;

        }
    }
}
