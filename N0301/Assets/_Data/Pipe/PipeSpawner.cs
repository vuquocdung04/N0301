
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : LoadAutoComponents
{
    [SerializeField] protected Transform poolHolders;
    [SerializeField] protected List<PipeCtrl> pipeCtrls = new();
    int rand;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomPipe),2f,2f);
    }


    protected virtual void SpawnRandomPipe()
    {
        this.rand = Random.Range(0, this.pipeCtrls.Count);
        PipeCtrl pipe = SimplePool2.Spawn(this.pipeCtrls[rand], new Vector2(10,Random.Range(-3,3)), Quaternion.identity);
        pipe.transform.SetParent(this.poolHolders);
        pipe.gameObject.SetActive(true);
    }

    #region LoadComponent
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPipeCtrl();
        this.LoadPoolHolder();
    }

    protected virtual void LoadPoolHolder()
    {
        if (this.poolHolders != null) return;
        this.poolHolders = transform.Find("PoolHolders");

        if (this.poolHolders == null)
        {
            this.poolHolders = new GameObject("PoolHolders").transform;
            this.poolHolders.SetParent(this.transform);
        }
    }
    protected virtual void LoadPipeCtrl()
    {
        if (this.pipeCtrls.Count > 0) return;
        PipeCtrl[] pipe = GetComponentsInChildren<PipeCtrl>();
        this.pipeCtrls = new List<PipeCtrl>(pipe);
        this.HidePrefabs();
    }

    protected virtual void HidePrefabs()
    {
        foreach (var child in this.pipeCtrls)
        {
            child.gameObject.SetActive(false);
        }
    }
    #endregion
}
