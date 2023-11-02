using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public delegate void GiveSecret(string secretData);

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    //Delegate
    public GiveSecret giveSecret;

    private void OnEnable()
    {
        giveSecret += WriteData;
    }

    private void OnDisable()
    {
        giveSecret -= WriteData;
    }

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO: Add the parameter here to handle the secret.


        //You can log the value to test it :)
        consumer.ConsumeDelegate(giveSecret);
    }

    private void WriteData(string secret)
    {
        Debug.Log(secret);
    }
}
