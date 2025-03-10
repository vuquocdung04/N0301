using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PipeType
{
    gray,
    orange,
    green
}


[CreateAssetMenu(menuName = "SO/PipeSO")]
public class PipeSO : ScriptableObject
{
    public List<PipeScore> pipeScores;

    public PipeScore GetPipeScore(PipeType pipeType)
    {
        foreach (PipeScore score in pipeScores)
        {
            if(score.pipeType == pipeType) return score;
        }
        return null;
    }
}

[System.Serializable]

public class PipeScore
{
    public PipeType pipeType;
    public int score;
}
