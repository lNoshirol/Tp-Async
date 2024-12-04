using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Cysharp.Threading.Tasks;
using static UnityEngine.ParticleSystem;
using System.Threading;

public class TurnCubeAsync : MonoBehaviour
{
    [SerializeField] GameObject cube;

    [SerializeField] float tuurnSpeed;

    [SerializeField] bool chillNothingReallyImportantHere = true;

    [SerializeField] bool STOP;

    // Update is called once per frame
    void Update()
    {

        if (chillNothingReallyImportantHere)
        {
            tuurnSpeed += 0.05f;
        }
        else
        {
            tuurnSpeed -= 0.05f;
        }

        if (tuurnSpeed > 5)
        {
            chillNothingReallyImportantHere = false;
        }
        else if (tuurnSpeed < 1)
        {
            chillNothingReallyImportantHere = true;
        }
    }

    public void StartCanTurn()
    {
        CanTurn();
        STOP = false;
    }

    public void StopCanTurn()
    {
        STOP = true;
    }

    public async void CanTurn()
    {
        for (int i = 0; i < 750; i++)
        {
            cube.transform.Rotate(new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2)) * tuurnSpeed);
            await UniTask.WaitUntil((() => !STOP));
        }
        
    }
}