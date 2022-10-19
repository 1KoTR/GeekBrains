using System.Threading.Tasks;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class ExecuteSetZeroJob : MonoBehaviour
{
    [SerializeField]
    private int[] _startNumbers;

    private NativeArray<int> _numbers;
    private JobHandle _jobHandle;

    private async void Start()
    {
        _numbers = new NativeArray<int>(_startNumbers.Length, Allocator.TempJob);
        for (int i = 0, length = _numbers.Length; i < length; i++)
            _numbers[i] = _startNumbers[i];

        var job = new SetZeroJob();
        job.Numbers = _numbers;

        _jobHandle = job.Schedule();
        _jobHandle.Complete();

        await PrintNumbers();

        _numbers.Dispose();
    }

    private async Task PrintNumbers()
    {
        while (!_jobHandle.IsCompleted)
            await Task.Yield();

        foreach (var number in _numbers)
            print(number);
    }
}
