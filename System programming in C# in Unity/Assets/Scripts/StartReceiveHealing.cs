using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartReceiveHealing : MonoBehaviour
{
    [SerializeField] private Unit _unit;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Key \'Space\' pressed");
            _unit.ReceiveHealing();
        }
    }
}
