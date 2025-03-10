using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PlayerCtrl : LoadAutoComponents
{
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    public Rigidbody2D Rigidbody2D => _rigidbody2D;

    [SerializeField] protected CircleCollider2D _circleCollider2D;
    public CircleCollider2D CircleCollider2D => _circleCollider2D;

    [SerializeField] protected Animator _animator;
    public Animator Animator => _animator;

    #region LoadComponent
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigidbody2D();
        this.LoadCircleCollider2D();
        this.LoadAnimator();
    }

    protected virtual void LoadAnimator()
    {
        if (_animator != null) return;
        _animator = GetComponentInChildren<Animator>();
    }

    protected virtual void LoadRigidbody2D()
    {
        if (_rigidbody2D != null) return;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 2f;
    }

    protected virtual void LoadCircleCollider2D()
    {
        if (_circleCollider2D != null) return;
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _circleCollider2D.radius = 0.3f;
    }
    #endregion
}
