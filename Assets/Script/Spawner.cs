using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] objectPrefabs;
    [SerializeField] float spawnLength = 2f;
    [SerializeField] float objectDuration;
    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectSpawner());
    }

    IEnumerator ObjectSpawner()
    {
        while(true)
        {
            var area = Random.Range(minTrans, maxTrans);
            var position = new Vector3(area, transform.position.y);
            GameObject gameObject = Instantiate(objectPrefabs[Random.Range(0, objectPrefabs.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawnLength);
            Destroy(gameObject, objectDuration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
