using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner1 : MonoBehaviour
{
    public GameObject healthPack;
    public List<GameObject> spawned;

    System.Collections.IEnumerator SpawnHealth()
    {
        if (spawned.Count < 10)
        {
            GameObject newHealth = GameObject.Instantiate(healthPack);

            Vector2 position = Random.insideUnitCircle * 50.0f;
            newHealth.transform.position = position;
            spawned.Add(newHealth);
        }
        yield return new WaitForSeconds(2.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnHealth());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
