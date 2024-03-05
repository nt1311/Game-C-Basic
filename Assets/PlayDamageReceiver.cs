using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// thừa kế DamageReceiver
public class PlayDamageReceiver : DamageReceiver
{
    protected PlayerController playerController;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if(this.IsDead()) this.playerController.playerStatus.Dead();
    }
}
