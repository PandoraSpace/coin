using DG.Tweening;
using UnityEngine;

public class Jumper
{
    private readonly Transform _transform;
    private readonly Config _config;
    
    private Vector3 _endValue = new Vector3(0f, 0.5f, 0f);
    private const int JUMP_COUNT = 1;
    private const float DURATION = 0.5f;

    public Jumper(Transform transform, Config config)
    {
        _transform = transform;
        _config = config;
    }

    public void Jump()
    {
        _transform.DOJump(_endValue, _config.JumpPower, JUMP_COUNT, DURATION).SetEase(Ease.InOutSine);
    }
}