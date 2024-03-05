using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // tạo liên kết trong read
    public Despawner despawner;

    // tưởng tự như start gọi 1 lần khi game bắt đầu ( awake gọi trước ) 
    private void Awake()
    {
        this.despawner = GetComponent<Despawner>(); 
    }
}
