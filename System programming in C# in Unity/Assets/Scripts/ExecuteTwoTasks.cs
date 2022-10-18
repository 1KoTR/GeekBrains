using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class ExecuteTwoTasks : MonoBehaviour
{
    private void Start()
    {
        var cts = new CancellationTokenSource();
        var plugToken = cts.Token;

        Task1(plugToken);
        Task2(plugToken);
    }

    private async void Task1(CancellationToken token)
    {
        await Task.Delay(2000);

        print("Task1 completed");
    }

    private async void Task2(CancellationToken token)
    {
        for (int i = 0; i < 60; i++)
            await Task.Yield();

        print("Task2 completed");
    }
}
