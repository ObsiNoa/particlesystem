using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class ParticleModule
{
    protected Particle _particle;

    private Vector3 direction;
    private float lifetime;
    private float speed;
    private float elapsedTime;
    public override void Init(Particle particle)
    {
        this._particle = particle;
        direction = Random.insideUnitSphere.normalized;
        speed = Random.Range(3f, 8f);
        lifetime = Random.Range(1f, 5f);
    }

    public override void Update(float deltaTime)
    {

    }
}