using NaughtyAttributes;
using System.Threading.Tasks;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{

    [Foldout("Test")]
    public int delay;

    [Foldout("Test")]
    public int startNumber;

    [Foldout("Test")]
    public int maxNumber;
    [Foldout("Test")]
    public int flyTime = 0;

    private void Start()
    {

        TestFunction(startNumber);
    }

    public async void TestFunction(int number)
    {
        Debug.Log(number);

        CheckMaxNumber(number);
        flyTime++;

        await Task.Delay(delay);

        if (number != 1)
        {
            TestFunction(NumerberIsPair(number) ? DivideBy2(number) : MultiplyBy3Plus1(number));
        }
        else
        {
            ThisIsTheEnd();
        }
    }

    public void CheckMaxNumber(int number)
    {
        if (number > maxNumber)
        {
            maxNumber = number;
        }
    }

    public bool NumerberIsPair(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool NumberIsOne(int number)
    {
        if (number ==1)
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }

    public int DivideBy2(int number)
    {
        return number / 2;
    }

    public int MultiplyBy3Plus1(int number)
    {
        return number * 3 + 1;
    }

    public void ThisIsTheEnd()
    {
        Debug.Log("Opération effectué : " + flyTime + " Pour une altitude maximum de : " + maxNumber);
    }

    [Button("ReStartFunction")]
    public void RestartFunction()
    {
        flyTime = 0;
        maxNumber = 0;

        TestFunction(startNumber);
    }
}