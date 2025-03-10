using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeScore : Pipe_Hit_Score
{
    protected override void OnTriggerEnter2D()
    {
        ObserverManager<int>.Notify("Score", this.pipeCtrl.PipeSO.GetPipeScore(PipeType.orange).score);

    }
}
