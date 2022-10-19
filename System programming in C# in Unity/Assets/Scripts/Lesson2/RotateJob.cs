using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

public struct RotateJob : IJobParallelForTransform
{
    [ReadOnly]
    public float RotationSpeed;
    [ReadOnly]
    public Vector3 RotationAxis;
    [ReadOnly]
    public float DeltaTime;

    public void Execute(int index, TransformAccess transform)
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + Vector3.up * RotationSpeed * DeltaTime);
    }
}
