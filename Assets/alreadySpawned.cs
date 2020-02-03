using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alreadySpawned : MonoBehaviour
{
    private bool spawned;
    // Start is called before the first frame update
    void Start()
    {
        spawned = false;
    }

    public void changeSpawned()
    {
        spawned = true;
    }

    public bool getSpawned()
    {
        return spawned;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
