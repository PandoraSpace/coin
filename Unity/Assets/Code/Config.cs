using UnityEngine;

[CreateAssetMenu]
public class Config : ScriptableObject
{
    [SerializeField, Range(0.5f, 2.5f)] private float _durationRotate;
    [SerializeField] private float _jumpPower;

    public float DurationRotate => _durationRotate;

    public float JumpPower => _jumpPower;
}