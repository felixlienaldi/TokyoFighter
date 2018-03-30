using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

   
    public int Randomize;

    public bool ready = true;
    public Transform[] SpawnLocation;

    public GameObject EnemyPerson;
   
    public Vector3 direction; 

   

    // Use this for initialization
    void Start () {
       
        StartCoroutine(Spawn(EnemyPerson));
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public IEnumerator Spawn(GameObject obj)
    {
        while (ready)
        {
            Randomize = Random.Range(0, SpawnLocation.Length);
            yield return new WaitForSeconds(2f);
            Instantiate(obj, SpawnLocation[Randomize].position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    

   
}
