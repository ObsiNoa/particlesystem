using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class Generation : MonoBehaviour
{
    [SerializeField] public float minSpeedParticle;
    [SerializeField] public float maxSpeedParticle;
    [SerializeField] public float minTimeToLive;
    [SerializeField] public float maxTimeToLive;
    [SerializeField] public GameObject particlePrefab;
    [SerializeField] float rate;
    [SerializeField] private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        CreateParticle();
        
    }

    void CreateParticle()
    {
        if (timer >= 1/rate)
        {
            timer = 0;
            Particle.particle = Instantiate(particlePrefab,transform);
            particle.Init(
                Random.onUnitSphere,
                Random.ColorHSV,
                Random.Range(minSpeedParticle, maxSpeedParticle),
                Random.Range(minTimeToLive, maxTimeToLive)
                );
            
            if (mouvementModule)
            {
                MouvementModule mouvementModule = new MouvementModule();
                mouvementModule.Init(Random.onUnitSphere, Random.Range(minSpeedParticle, maxSpeedParticle));
                modules.AddModule(mouvementModule);
            }

            if (visualModule)
            {
                VisualModule visualModule = new VisualModule();
                visualModule.Init(this);
                modules.AddModule(visualModule);
            }

            if (lifeCycleModule)
            {
                LifeCycleModule lifeCycleModule = new LifeCycleModule();
                lifeCycleModule.Init(particle, Random.Range(minTimeToLive, maxTimeToLive);
                modules.AddModule(lifeCyclelModule);
            }

        }
    }

}
