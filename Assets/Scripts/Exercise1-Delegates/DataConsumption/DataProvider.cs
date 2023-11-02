using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate int GetAge(int personId);
public delegate string GetName(int personId);
public delegate short GetPostalCode(int personId);

public class DataProvider : MonoBehaviour
{
    [SerializeField] private DataConsumer dataConsumer;
    
    [SerializeField] private int genericAge = 18;
    [SerializeField] private string genericName = "Santiago";
    [SerializeField] private short genericPostalCode = 1408;

    //Delegates
    public GetAge getAge;
    public GetName getName;
    public GetPostalCode getPostalCode;

    private void OnEnable()
    {
        getAge += GetAge;
        getName += GetName;
        getPostalCode += GetPostalCode;
    }

    private void OnDisable()
    {
        getAge -= GetAge;
        getName -= GetName;
        getPostalCode -= GetPostalCode;
    }

    private int GetAge(int personId)
    {
        return genericAge;
    }
    
    private string GetName(int personId)
    {
        return genericName;
    }
    
    private short GetPostalCode(int personId)
    {
        return genericPostalCode;
    }

    [ContextMenu("Test report")]
    private void TestReport()
    {
        dataConsumer.ReportPersonData(0, getName, getAge, getPostalCode);
    }
}