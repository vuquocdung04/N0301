using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Pipe_Hit_Score : LoadAutoComponents
{
    [SerializeField] protected PipeCtrl pipeCtrl;
    protected abstract void OnTriggerEnter2D();

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        UIManager.Instance.UICenter.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }


    #region LoadComponent
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPipeCtrl();
    }

    protected virtual void LoadPipeCtrl()
    {
        if (pipeCtrl != null) return;
        pipeCtrl = GetComponentInParent<PipeCtrl>();
    }

    #endregion

}
