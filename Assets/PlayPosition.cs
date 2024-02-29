using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPosition : MonoBehaviour
{
    float playerPosx;
    List<GameObject> minions;// Tạo biến, chưa khỏi tạo 

    GameObject minionPerfab;
    public GameObject maxionPerfab;
    // Start is called before the first frame update
    private void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.playerPosx = transform.position.x;// khởi tạo

     
        int spawnLocation = 7;
        if (this.playerPosx >= spawnLocation)
            this.Spawn();
        else
            this.NotSpawn();
    }

  

    void Spawn()
    {
        Debug.Log("Spawn");
        if (this.minions.Count >= 7) return;
        int index = this.minions.Count +1;
        GameObject minion = new GameObject("Minion #" + index);
        MinionScript minionScript = minion.AddComponent<MinionScript>();
        minionScript.SetPosition(index);
        this.minions.Add(minion);
     }
    void NotSpawn()
    {
     }
}
