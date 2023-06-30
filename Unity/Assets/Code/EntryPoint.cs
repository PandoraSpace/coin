using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private CoinProvider _coin;
    [SerializeField] private Config _config;
    
    private ClickHandler _clickHandler;
    private Repainter _repainter;
    private Rotator _rotator;
    private Jumper _jumper;

    private void Awake()
    {
        CreateServices();
        CreateClickHandler(_jumper);

        _rotator.StartRotate(_coin.Transform);
    }

    private void CreateServices()
    {
        _rotator = new Rotator(_config);
        _repainter = new Repainter(_coin.Material);
        _jumper = new Jumper(_coin.Transform, _config);
    }

    private void CreateClickHandler(Jumper jumper)
    {
        _clickHandler = new ClickHandler(_repainter, jumper, _coin.Particle);
        _coin.OnClick += _clickHandler.Click;
    }

    private void OnDestroy()
    {
        _repainter.Dispose();
        _coin.OnClick -= _clickHandler.Click;
    }
}