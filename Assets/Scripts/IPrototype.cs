using UnityEngine;

public interface IPrototype<T> where T : Component
{
    T Clone();
}