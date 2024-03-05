using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyController enemyController;


    private void Awake()
    {
        enemyController = GetComponent<EnemyController>();  
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // xử lý dame 
        DamageReceiver damageRevelver = collision.GetComponent<DamageReceiver>();
        damageRevelver.Receive(1);

        this.enemyController.despawner.Despawn();

      //  Debug.Log(collision.name);
    }
}
