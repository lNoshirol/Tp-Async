using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    [SerializeField] GameObject cube;

    [SerializeField] float tuurnSpeed;

    [SerializeField] bool chillNothingReallyImportantHere = true;

    [SerializeField] bool canTurn;

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
        StartCoroutine(CanTurn());
    }

    public void StopCanTurn()
    {
        StopAllCoroutines();
    }

    public IEnumerator CanTurn()
    {
        for (int i = 0; i < 400; i++)
        {
            cube.transform.Rotate(new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2)) * tuurnSpeed);
            yield return new WaitForSeconds(0.01f);
        }
    }
}