using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] public float tileSpeed = 4f;

    private void Update()
    {
        this.Moving();
    }

    protected virtual void Moving()
    {
        this.transform.parent.Translate(Vector2.left * tileSpeed * Time.deltaTime);
    }
}
