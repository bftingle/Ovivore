using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2400; i++) Instantiate(rock, new Vector3(Random.Range(-144.0f, 144.0f), Random.Range(-144.0f, 144.0f), 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
