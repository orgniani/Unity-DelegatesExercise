using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataProvider : MonoBehaviour
{
    [SerializeField] private DataConsumer dataConsumer;
    
    [SerializeField] private int genericAge = 18;
    [SerializeField] private string genericName = "name";
    [SerializeField] private short genericPostalCode = 1408;

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
        dataConsumer.ReportPersonData(0, GetName, GetAge, GetPostalCode);
    }
}