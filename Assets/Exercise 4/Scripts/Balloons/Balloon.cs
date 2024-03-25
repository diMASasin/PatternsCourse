using System;
using Assets.Exercise_4.Scripts;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public BalloonColors Color { get; private set; }

    public event Action<Balloon> WasBurst;

    public void Init(BalloonColors balloonColors)
    {
        Color = balloonColors;
    }

    public void Burst()
    {
        WasBurst?.Invoke(this);
        Destroy(gameObject);
    }
}
