using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
            SpawnAttacker();
        }
       
    }

    private void SpawnAttacker()
    {
        Instantiate( attackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
