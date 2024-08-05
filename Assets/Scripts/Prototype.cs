using UnityEngine;

public class Prototype : MonoBehaviour, IPrototype<Prototype>
{
    public Prototype Clone()
    {
        Prototype instance = Instantiate(this, transform.localPosition, transform.localRotation);
        instance.transform.localScale = transform.localScale;
        instance.gameObject.SetActive(true);
        return instance;
    }
}