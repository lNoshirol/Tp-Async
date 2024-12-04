using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayOne : MonoBehaviour
{
    public string tkt;

    public List<char> a;
    public List<char> b;

    private void Start()
    {
        string tempoNumber;

        foreach (char i in tkt)
        {
            if (i != ':' && i != '?')
            {
                tempoNumber = "a";
            }
        }
    }
}