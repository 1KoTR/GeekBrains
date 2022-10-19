using Unity.Collections;
using Unity.Jobs;

public struct SetZeroJob : IJob
{
    public NativeArray<int> Numbers;

    public void Execute()
    {
        for (int i = 0, length = Numbers.Length; i < length; i++)
            if (Numbers[i] > 10)
                Numbers[i] = 0;
    }
}
