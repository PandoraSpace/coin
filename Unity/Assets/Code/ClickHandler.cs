using UnityEngine;

public class ClickHandler
{
    private Repainter _repainter;
    private Jumper _jumper;
    private ParticleSystem _particle;

    public ClickHandler(Repainter repainter, Jumper jumper, ParticleSystem particle)
    {
        _repainter = repainter;
        _jumper = jumper;
        _particle = particle;
    }

    public void Click()
    {
        _repainter.Recolor();
        _jumper.Jump();
        _particle.Play();
    }
}