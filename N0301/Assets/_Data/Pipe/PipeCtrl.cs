using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PipeCtrl : LoadAutoComponents
{
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    public Rigidbody2D Rigidbody2D => _rigidbody2D;
    [SerializeField] protected PipeMovement pipeMovement;
    public PipeMovement PipeMovement => pipeMovement;

    [SerializeField] protected PipeDespawn pipeDespawn;
    public PipeDespawn PipeDespawn => pipeDespawn;

    [SerializeField] protected PipeSO pipeSO;
    public PipeSO PipeSO => pipeSO;

    #region LoadComponent
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigidbody2D();
        this.LoadPipeMovement();
        this.LoadPipeDespawn();
        this.LoadPipeSO();
    }
    protected virtual void LoadRigidbody2D()
    {
        if (_rigidbody2D != null) return;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.bodyType = RigidbodyType2D.Static;
    }

    protected virtual void LoadPipeMovement()
    {
        if (this.pipeMovement != null) return;
        this.pipeMovement = GetComponentInChildren<PipeMovement>();
    }

    protected virtual void LoadPipeDespawn()
    {
        if (this.pipeDespawn != null) return;
        this.pipeDespawn = GetComponentInChildren<PipeDespawn>();
    }
    protected virtual void LoadPipeSO()
    {
        if (this.pipeSO != null) return;
        this.pipeSO = Resources.Load<PipeSO>("PipeSO");
    }
    #endregion
}
