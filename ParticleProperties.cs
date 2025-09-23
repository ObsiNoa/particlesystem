using NUnit.Framework;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;

public class Particle : ParticleModule
{
    private List<ParticleModule> modules;

    public void Init(float speed, float lifetime, Vector3 direction)
    {

        modules = new List<ParticleModule>();
        MouvementModule mouvementModule = new MouvementModule();
        mouvementModule.Init(this);
        modules.Add(mouvementModule);

        VisualModule visualModule = new VisualModule();
        visualModule.Init(this);
        modules.Add(visualModule);

        LifeCycleModule lifeCycleModule = new LifeCycleModule();
        lifeCycleModule.Init(this);
        modules.Add(lifeCyclelModule);

    }

    public void AddModule(ParticleModule module)
    {

    }


    void Update()
    {
        for (int i = 0; i < modules.Count; i++)
        {
            modules[i].Update(Time.deltaTime);
        }
        elapsedTime += Time.deltaTime;
    }
}
