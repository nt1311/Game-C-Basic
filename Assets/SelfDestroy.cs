using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // thự hiện câu lệnh sau (2s) 
        Invoke("Destroy", 13f);
    }
    private void Destroy()
    {
        Destroy(gameObject);

    }
}
    
