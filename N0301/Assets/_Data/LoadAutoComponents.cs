using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAutoComponents : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    void Reset()
    {
        this.LoadComponents();
        this.ResetValue();
    }
    protected virtual void LoadComponents()
    {

    }

    protected virtual void ResetValue()
    {

    }

}
