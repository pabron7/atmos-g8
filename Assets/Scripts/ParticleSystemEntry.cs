using System;
using UnityEngine;

[Serializable]
public class ParticleSystemEntry
{
    public ParticleSystem particleSystem;
    public bool activate;
    public float density = 1;
    public float precipitation =1;
    public float humidity=1;
}
