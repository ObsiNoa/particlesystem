using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class LifeCycleModule : ParticleModule
{


    public override void Init(Particle particle, Vector3 direction, float speed)
    {
        base.Init(particle);

    }

    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        elapsedTime += deltaTime;
        if(elapsedTime >= lifeTime)
        {
            destroy(gameObject);
        }
    }
}
