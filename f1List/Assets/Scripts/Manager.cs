using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Manager : MonoBehaviour
{
    public List<Driver> drivers = new List<Driver>();
    public List<Line> lines = new List<Line>();
    public List<Driver> sortList = new List<Driver>();

    public UnityEvent onCalculationEnd;

    

    private void Start()
    {
        GetScore();
        Sort();
        FillDriverPrefs();
        onCalculationEnd.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    void GetScore()
    {
        
    }

    void Sort()
    {
        drivers.Sort(SortCalculate);
    }

    void FillDriverPrefs()
    {
        for (int i = 0; i < drivers.Count; i++)
        {
            lines[i].nameSurname = drivers[i].nameSurname;
            lines[i].nation = drivers[i].nation;
            lines[i].score = drivers[i].score;
        }
    }

    int SortCalculate(Driver a, Driver b)
    {
        if (a.score > b.score)
        {
            return -1;
        }
        else
        {
            return +1;
        }
        return 0;
    }
}
