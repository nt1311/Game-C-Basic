using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPosition : MonoBehaviour
{
   // float playerPosx;
    List<GameObject> minions;// Tạo biến, chưa khỏi tạo 
    public GameObject minionPerfab;

    protected float spawnDelay = 1f;
    protected float spawnTimer = 0f;

    public int index = 1;
    // Start is called before the first frame update
    private void Start()
    {
       
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.playerPosx = transform.position.x;// khởi tạo
      //  int spawnLocation = 7;
      //  if (this.playerPosx >= spawnLocation)
            this.Spawn();
      //  else
      //     this.NotSpawn();

        CheckMinionDead();
    }

  

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < spawnDelay) return;
        
            this.spawnTimer = 0;
        
        

      //  Debug.Log("Spawn");
        if (this.minions.Count >= 7) return;
        int index = this.minions.Count +1;
        GameObject minion = Instantiate(this.minionPerfab);
        minion.name = "Bom #" + index;

        if (index == 7) index = 1;
       

        minion.transform.position = transform.position; // lấy vị trí hiện tại của nhân vật
        minion.gameObject.SetActive(true);//thây đổi trạng thái khi spawn đối tượng ra 
        MinionScript minionScript = minion.AddComponent<MinionScript>();
        minionScript.SetPosition(index);
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0;i < this.minions.Count;i++)
        {
            minion = this.minions[i];
            if(minion == null) this.minions.RemoveAt(i);
        }
    }
    void NotSpawn()
    {
       
    }
}
