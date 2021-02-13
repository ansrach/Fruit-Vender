using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOBJ : MonoBehaviour
{
    public List<GameObject> targets;    
    public float rate = 1f;
    
    private Timer timer;
    void Start()
    {
        InvokeRepeating("Spawn", 1f, rate);        
        timer = GameObject.Find("Canvas").GetComponent<Timer>();
    }

    void Spawn()
    {
        if(timer.gameStarted == true)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-1, 1), Random.Range(2, 3), Random.Range(2, 3));
            int spawnIndex = Random.Range(0, targets.Count);
            Instantiate(targets[spawnIndex], spawnPos, targets[spawnIndex].transform.rotation);
        }
        //Vector3 spawnPos = new Vector3(Random.Range(-1, 1), Random.Range(8, 12), Random.Range(10, 20));
        //int spawnIndex = Random.Range(0, targets.Count);
        //Instantiate(targets[spawnIndex], spawnPos, targets[spawnIndex].transform.rotation);
        //Instantiate(spawnObject, new Vector3(Random.Range(-1, 1), Random.Range(8, 12), Random.Range(10, 20)), Quaternion.identity);
        //Instantiate(spawnObject, new Vector3(0, 10, 0), Quaternion.identity);
    }
}
