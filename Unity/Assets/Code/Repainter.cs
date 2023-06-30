using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Repainter : IDisposable
{
    private readonly Material _material;
    private readonly Color _defaulColor;

    public Repainter(Material material)
    {
        _material = material;
        _defaulColor = material.color;
    }

    public void Recolor()
    {
        _material.color = new Color(Random.value, Random.value, Random.value, 1f);
    }

    public void Dispose()
    {
        _material.color = _defaulColor;
    }
}