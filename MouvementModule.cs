using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class MouvementModule : ParticleModule
{
    private float speed;
    private Vector3 direction;

    public override void Init(Particle particle, Vector3 direction, float speed)
    {
        base.Init(particle);

        _direction = direction;
        _speed = speed;
    }

    public override void Update(float deltaTime)
    {
        base .Update(deltaTime);

        Transform.position += direction * speed * deltaTime;
    }
}
