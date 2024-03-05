using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  
    public Transform player;
    protected float speed = 7f;
    protected float disLimit = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("follow", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }
    
    void Follow()
    {
     
        Vector3 distance = this.player.position - transform.position;
        if(distance.sqrMagnitude >= this.disLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.disLimit;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
