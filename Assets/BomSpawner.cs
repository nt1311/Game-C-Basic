using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomSpawner : MonoBehaviour
{

    protected GameObject bomPrefab;
    protected float time = 0;
    protected float deplay = 2f;

    private void Awake()
    {
        // lấy đôi tượng trong read time
        this.bomPrefab = GameObject.Find("BomPrefab");
        this.bomPrefab.SetActive(false);
      
    }
    private void Update()
    {
        this.Spawn();
    }
    protected virtual void Spawn()
    {
        this.time += Time.deltaTime;
        if (this.time < deplay)
            return;
        this.time = 0;

        GameObject bom = Instantiate(this.bomPrefab);
        bom.transform.position = GameObject.Find("Player").transform.position;
        bom.SetActive(true);

    }

}
