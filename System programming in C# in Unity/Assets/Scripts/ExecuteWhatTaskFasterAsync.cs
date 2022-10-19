using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class ExecuteWhatTaskFasterAsync : MonoBehaviour
{
    [SerializeField] private ExecuteTwoTasks _executeTwoTasks;

    private async void Start()
    {
        using var cts = new CancellationTokenSource();
        var ct = cts.Token;

        var result =  await Utils.WhatTaskFasterAsync(ct, _executeTwoTasks.Task1(ct), _executeTwoTasks.Task2(ct));
        print(result);
    }
}
