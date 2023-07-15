using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipSpawn : MonoBehaviour
{

    public GameObject pip;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer +Time.deltaTime;
        } 
        else
        {
            pipSpawn();
            timer = 0;
        }
        
        void pipSpawn()
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            Instantiate(pip, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
    }
}
