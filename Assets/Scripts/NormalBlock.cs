using UnityEngine;

/// <summary>
/// Standard block using default settings.
/// </summary>
public class NormalBlock : BlockBase
{
    protected override void Awake()
    {
        mass = 1f;
        base.Awake();
    }
}