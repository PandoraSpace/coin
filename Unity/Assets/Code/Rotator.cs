using DG.Tweening;
using UnityEngine;

public class Rotator
{
    private readonly Config _config;

    public Rotator(Config config)
    {
        _config = config;
    }

    public void StartRotate(Transform transform)
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), _config.DurationRotate, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}