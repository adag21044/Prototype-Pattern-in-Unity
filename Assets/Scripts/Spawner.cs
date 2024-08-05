using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Prototype cubePrototype;

    [ContextMenu("CubeMaker")]
    public void CubeMaker()
    {
        var newCube = cubePrototype.Clone();
        newCube.name = "cube";
    }
}