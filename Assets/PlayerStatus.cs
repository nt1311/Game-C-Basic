using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// trạng trái chết của nhân vật
public class PlayerStatus : MonoBehaviour
{ // tạo ta kiển kết với player controller.
    protected PlayerController playerController;

    private void Awake()
    {
        this.playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
     //   this.CheckDead();
    }
    protected virtual void CheckDead()
    {
       if(this.playerController.damageReceiver.IsDead()) this.Dead();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
