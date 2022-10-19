using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class ExecuteTwoTasks : MonoBehaviour
{
    private void Start()
    {
        using var cts = new CancellationTokenSource();
        var ct = cts.Token;

        Task1(ct);
        Task2(ct);
    }

    public async Task Task1(CancellationToken ct)
    {
        await Task.Delay(1000);
        if (ct.IsCancellationRequested)
            return;

        print("Task1 completed");
    }

    public async Task Task2(CancellationToken ct)
    {
        for (int i = 0; i < 60; i++)
        {
            if (ct.IsCancellationRequested)
                return;
            await Task.Yield();
        }

        print("Task2 completed");
    }
}
