using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : LoadAutoComponents
{
    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected float jumpForce = 5f;
    [SerializeField] protected float rotateSpeed = 3f;

    private void Update()
    {
        this.Flying();
    }

    private void FixedUpdate()
    {
        this.Rotating();
    }

    protected virtual void Flying()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            playerCtrl.Rigidbody2D.velocity = Vector2.up * jumpForce;
        }
    }

    protected virtual void Rotating()
    {
        this.transform.parent.rotation = Quaternion.Euler(0, 0, playerCtrl.Rigidbody2D.velocity.y * rotateSpeed * rotateSpeed);
    }

    #region LoadComponent
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }

    protected virtual void LoadPlayerCtrl()
    {
        if (playerCtrl != null) return;
        playerCtrl = GetComponentInParent<PlayerCtrl>();
    }

    #endregion
}
