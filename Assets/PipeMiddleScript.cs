using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript: MonoBehaviour
{
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectsWithTag("Logic").GetComponent<LogicScript>();
        //this is the line that I seem to have a problem with^^^
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
