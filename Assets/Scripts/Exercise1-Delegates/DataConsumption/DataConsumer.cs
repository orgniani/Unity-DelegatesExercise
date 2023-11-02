using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConsumer : MonoBehaviour
{
    //TODO: Complete this method
    public void ReportPersonData(int personId, GetName getName, GetAge getAge, GetPostalCode getPostalCode)
    {
        string name = string.Empty;
        int age = -1;
        short postalCode = -1;

        name = getName(personId);
        age = getAge(personId);
        postalCode = getPostalCode(personId);

        var dataReport = string.Format("name: {0}, age: {1}, postal code: {2}", name, age, postalCode);
        Debug.Log($"{name}: Giving report on Data. {dataReport}");
    }
}
