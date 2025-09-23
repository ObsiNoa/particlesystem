using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class VisualModule : ParticleModule
{


    public override void Init(Particle particle, Vector3 direction, float speed)
    {
        base.Init(particle);

        _particle.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public override void Update(float deltaTime)
    {

    }
}
