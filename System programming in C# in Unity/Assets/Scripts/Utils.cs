using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Unity.VisualScripting.FullSerializer;

public static class Utils
{
    public static async Task<bool> WhatTaskFasterAsync(CancellationToken ct, Task task1, Task task2)
    {
        var t = await Task.WhenAny(task1, task2);
        if (ct.IsCancellationRequested)
            return false;
        return t == task1;
    }
}
