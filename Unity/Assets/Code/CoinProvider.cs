using System;
using UnityEngine;

public class CoinProvider : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Material _material;
    [SerializeField] private ParticleSystem _particle;

    public Transform Transform => _transform;
    public Material Material => _material;
    public ParticleSystem Particle => _particle;

    public event Action OnClick;

    private void OnMouseDown()
    {
        OnClick?.Invoke();
    }
}