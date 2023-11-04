using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret.
        //You can log the value to test it :)

        consumer.ConsumeDelegate(LogSecret);
    }

    private void LogSecret(string secret)
    {
        Debug.Log(secret);
    }
}
