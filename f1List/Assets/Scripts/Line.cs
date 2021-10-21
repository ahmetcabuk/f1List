using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Line : MonoBehaviour
{
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI nationTMP;
    public TextMeshProUGUI scoreTMP;

    public string nameSurname;
    public string nation;
    public int score;

    private Manager _manager;

    private void Awake()
    {
        _manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    private void OnEnable()
    {
        _manager.onCalculationEnd.AddListener(UpdateText);
    }

    private void OnDisable()
    {
        _manager.onCalculationEnd.RemoveListener(UpdateText);
    }

    private void UpdateText()
    {
        nameTMP.text = nameSurname;
        nationTMP.text = nation;
        scoreTMP.text = score.ToString();
    }
}
