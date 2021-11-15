using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++) Instantiate(prefab, new Vector3(Random.Range(-144.0f, 144.0f), Random.Range(-144.0f, 144.0f), 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
