using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : MonoBehaviour
{
    [SerializeField] protected float timeLife = 7f;
    [SerializeField] protected float currentTime = 0;

    private void OnEnable()
    {
        this.currentTime = 0;
    }

    private void Update()
    {
        this.currentTime += Time.deltaTime;
        if (this.currentTime > this.timeLife)
            SimplePool2.Despawn(this.transform.parent.gameObject);
    }
}
