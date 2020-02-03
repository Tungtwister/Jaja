using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTrigger : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    private bool bossSpawned;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        bossSpawned = false;
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player" && !this.transform.parent.GetComponent<alreadySpawned>().getSpawned())
        {
            this.transform.parent.GetComponent<alreadySpawned>().changeSpawned();
            print("Spawned");

            int index = UnityEngine.Random.Range(0, 2);
            if (!bossSpawned && index == 1)
            {
                bossSpawned = true;
                Vector3 pos = new Vector3(Random.Range(-110, 110), Random.Range(-50, 50), 0);
                var obj = Instantiate(Boss, this.transform.parent.position + pos, Quaternion.identity);
                obj.transform.parent = this.transform.parent;
            }
            else
            {
                for (int i = 0; i < Random.Range(7, 15); i++)
                {
                    int prefabIndex = UnityEngine.Random.Range(0, 3);
                    Vector3 pos = new Vector3(Random.Range(-110, 110), Random.Range(-50, 50), 0);
                    var obj = Instantiate(prefabList[prefabIndex], this.transform.parent.position + pos, Quaternion.identity);
                    obj.transform.parent = this.transform.parent;
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
